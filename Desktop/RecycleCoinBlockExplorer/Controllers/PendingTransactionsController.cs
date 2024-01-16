using Microsoft.AspNetCore.Mvc;
using RecycleCoin.Grpc;
using RecycleCoinBlockExplorer.Models.Entity;

namespace RecycleCoinBlockExplorer.Controllers
{
	public class PendingTransactionsController : Controller
	{
		readonly bool _sunucuDurum;
		readonly List<Islem> _bekleyenIslemler;


		public PendingTransactionsController()
		{
			Program.SunucuDurum();
			_sunucuDurum = Program.SunucuDurum();
			_bekleyenIslemler = new List<Islem>();
			BekleyenIslemleriGuncelle();
		}

		public async void BekleyenIslemleriGuncelle()
		{
			//do
			//{
			//} while (await Program.sayac.WaitForNextTickAsync());
			try
			{

				if (_sunucuDurum)
				{
					var yanit = Program.islemServis.HavuzdanSonNadetIslemGetir(new IslemIstek { Adet = 25 });
					if (yanit != null && yanit.Durum && yanit.Islemler.Count > 0)
					{
						_bekleyenIslemler.Clear();
						_bekleyenIslemler.AddRange(yanit.Islemler);
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
			ViewBag.Islemler = _bekleyenIslemler;
			return View();
		}
	}
}
