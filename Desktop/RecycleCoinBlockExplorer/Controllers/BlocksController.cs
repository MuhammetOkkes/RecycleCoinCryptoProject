using Microsoft.AspNetCore.Mvc;
using RecycleCoin.Grpc;
using RecycleCoinBlockExplorer.Models.Entity;

namespace RecycleCoinBlockExplorer.Controllers
{
	public class BlocksController : Controller
	{
		readonly bool _sunucuDurum;
		readonly List<Blok> _bloklar;

		public BlocksController()
		{
			Program.SunucuDurum();
			_sunucuDurum = Program.SunucuDurum();
			_bloklar = new List<Blok>();
			BloklariGuncelle();
		}

		public async void BloklariGuncelle()
		{
			//do
			//{
			//} while (await Program.sayac.WaitForNextTickAsync());
			try
			{
				if (_sunucuDurum)
				{
					var yanit = Program.blokServis.SonNadetBlokGetir(new BlokIstek { Adet = 25 });
					if (yanit != null && yanit.Durum && yanit.Bloklar.Count > 0)
					{
						_bloklar.Clear();
						_bloklar.AddRange(yanit.Bloklar);
					}
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		public Blok BlokGetir(string? karma, long yukseklik = 0)
		{
			var yanit = new BlokDurum();
			if(karma != null)
			{
				yanit = Program.blokServis.KarmaIleTekilGetir(new BlokIstek { Karma = karma });
				if (yanit.Durum && yanit.Blok != null) return yanit.Blok;
				else return null;
			}
			else
			{
				yanit = Program.blokServis.YukseklikIleTekilGetir(new BlokIstek { Yukseklik = yukseklik });
				if (yanit.Durum && yanit.Blok != null) return yanit.Blok;
				else return null;
            }
		}

		private void DogrulayiciIleBloklariGetir(string dogrulayici)
		{
   //         if (dogrulayici != null)
   //         {
   //             yanit = Program.blokServis.DogrulayiciIleListeGetir(new BlokIstek { Dogrulayici = dogrulayici });
   //             if (yanit.Durum && yanit.Bloklar != null && yanit.Bloklar.Count > 0) return yanit.Bloklar.ToList();
   //             else return null;
   //         }
			//return null;
        }

		[Route("Block/Yukseklik+{yukseklik}")]
		public IActionResult Block(long yukseklik)
		{
            ViewBag.SunucuDurum = _sunucuDurum;
			ViewBag.SonYuseklik = _bloklar.First().Yukseklik;
			ViewBag.Blok = BlokGetir(karma:null, yukseklik: yukseklik);
            return View();
		}

		[Route("Block/Karma+{karma}")]
		public IActionResult Block(string karma)
		{
			ViewBag.SunucuDurum = _sunucuDurum;
			ViewBag.SonYuseklik = _bloklar.First().Yukseklik;
			ViewBag.Blok = BlokGetir(karma: karma);
			return View();
		}

		public IActionResult Index()
		{
			ViewBag.SunucuDurum = _sunucuDurum;
			ViewBag.Bloklar = _bloklar;
			return View();

		}
	}
}
