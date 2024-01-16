using Microsoft.AspNetCore.Mvc;
using RecycleCoin.Grpc;

namespace RecycleCoinBlockExplorer.Controllers
{
    public class AccountController : Controller
    {
        public Hesap _hesap;
        public List<Islem> _islemler;
        public List<Islem> _bekleyenIslemler;
        public List<Islem> _bloklar;
        public double _onaylanmamisBakiye;


        public AccountController()
        {
            _islemler= new List<Islem>();
            _bekleyenIslemler= new List<Islem>();
            _bloklar= new List<Islem>();
            _onaylanmamisBakiye= 0.0;
            HesabınIslemleriniGetir();
            DogrulayicininBloklariniGetir();
		}

        private void HesapGetir(string adres)
        {
            var yanit = Program.hesapServis.AdresIleGetir(new HesapIstek { Adres = adres });
            if (!yanit.Durum || yanit.Hesap == null) return;
            _hesap = yanit.Hesap;
        }

        void HesabınIslemleriniGetir()
        {
            if (Program.SunucuDurum() && _hesap != null)
            {
				var yanit = Program.islemServis.AdresIleListeGetir(new IslemIstek { Adres = _hesap.Adres });
				if (yanit != null && yanit.Durum && yanit.Islemler.Count > 0)
				{
					_islemler.Clear();
					_islemler.AddRange(yanit.Islemler);
				}
                yanit = null;
                yanit = Program.islemServis.HavuzdanAdresIleListeGetir(new IslemIstek { Adres = _hesap.Adres });
				if (yanit != null && yanit.Durum && yanit.Islemler.Count > 0)
				{
                    _bekleyenIslemler.Clear();
                    _bekleyenIslemler.AddRange(yanit.Islemler);
                    foreach (var islem in _bekleyenIslemler)
                    {
                        if (islem.Alici == _hesap.Adres) _onaylanmamisBakiye += islem.Tutar;
                        else if(islem.Gonderen == _hesap.Adres) _onaylanmamisBakiye -= (islem.Tutar + islem.Ucret);
                    }
				}
			}
        }

        void DogrulayicininBloklariniGetir()
        {
            if (Program.SunucuDurum() && _hesap != null)
            {
                var yanit = Program.blokServis.DogrulayiciIleListeGetir(new BlokIstek { Dogrulayici = _hesap.Adres });
                if(yanit != null && yanit.Durum && yanit.Bloklar.Count > 0)
                {
                    _bloklar.Clear();
                   // _bloklar.AddRange(yanit.Bloklar.ToList());
                }
            }
        }

        public IActionResult Index()
        {
            ViewBag.Hesap = _hesap;
            ViewBag.Bloklar = _bloklar;
			ViewBag.BekleyenIslemler = _bekleyenIslemler;
			ViewBag.Islemler = _islemler;
			ViewBag.OnaylanmamisBakiye = _onaylanmamisBakiye;
			return View();
        }
    }
}
