using Microsoft.AspNetCore.Mvc;
using RecycleCoin.Grpc;
using RecycleCoinBlockExplorer.Models.Entity;
using System.Security.Policy;

namespace RecycleCoinBlockExplorer.Controllers
{
	public class TransactionsController : Controller
	{
		readonly bool _sunucuDurum;
		readonly List<Islem> _islemler;

		public TransactionsController()
		{
			Program.SunucuDurum();
			_sunucuDurum = Program.SunucuDurum();
			_islemler = new List<Islem>();
			IslemleriGuncelle();
		}


		public async void IslemleriGuncelle()
		{
			//do
			//{
			//} while (await Program.sayac.WaitForNextTickAsync());
			try
			{

				if (_sunucuDurum)
				{
					var yanit = Program.islemServis.SonNadetIslemGetir(new IslemIstek { Adet = 25 });
					if (yanit != null && yanit.Durum && yanit.Islemler.Count > 0)
					{
						_islemler.Clear();
						_islemler.AddRange(yanit.Islemler);
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
			ViewBag.Islemler = _islemler;
			return View();
		}
	}
}
