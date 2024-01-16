using Microsoft.AspNetCore.Mvc;
using RecycleCoin.Grpc;
using RecycleCoinBlockExplorer.Models.Entity;

namespace RecycleCoinBlockExplorer.Controllers
{
    public class AccountsController : Controller
    {
		readonly bool _sunucuDurum;
		readonly List<Hesap> _hesaplar;

		public AccountsController()
        {
            Program.SunucuDurum();
            _sunucuDurum = Program.SunucuDurum();
            _hesaplar = new List<Hesap>();
			HesaplariGuncelle();

		}

		public async void HesaplariGuncelle()
		{
			//do
			//{
			//} while (await Program.sayac.WaitForNextTickAsync());
			try
			{

				if (_sunucuDurum)
				{
					var yanit = Program.hesapServis.EnZenginNadetHesapGetir(new HesapIstek { Adet = 25 });
					if (yanit != null && yanit.Durum && yanit.Hesaplar.Count > 0)
					{
						_hesaplar.Clear();
						_hesaplar.AddRange(yanit.Hesaplar);
					}
				}
			}

			catch (Exception)
			{

				throw;
			}
		}

		public IActionResult Index()
        {
            ViewBag.SunucuDurum = _sunucuDurum;
            ViewBag.Hesaplar = _hesaplar;
            return View();
        }
    }
}
