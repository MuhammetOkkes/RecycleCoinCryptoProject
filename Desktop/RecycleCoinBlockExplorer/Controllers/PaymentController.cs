using Microsoft.AspNetCore.Mvc;
using RecycleCoin.Grpc;

namespace RecycleCoinBlockExplorer.Controllers
{
	public class PaymentController : Controller
	{
		public PaymentController()
		{

		}

		[HttpPost]
		public IActionResult Index(string adres)
		{
			if (!Program.SunucuDurum())
			{
				ViewBag.Mesaj = "Sunucuya bağlanılamıyor\n," +
					"bağlantı sağlandıktan sonra lütfen tekrar deneyin.";
				return View();
			}
			if (string.IsNullOrEmpty(adres) || adres.Trim().Length < 10)
			{
				ViewBag.Mesaj = "Lutfen Geçerli bir adres giriniz";
				return View();
			}
			double tutar = 50;
			bool sonuc = GonderimYap(adres, tutar);
			if (sonuc)
			{
				ViewBag.Mesaj = $"{adres[..10]}... adresine {tutar} RC gönderilmek üzere işlem havuzuna eklenmiştir. ";
			}
			return View();
		}

		public IActionResult Index()
		{
			return View();
		}

		private bool GonderimYap(string aliciAdres, double tutar)
		{
			bool sonuc = false;
			if (Program.SunucuDurum())
			{
				Islem islem;
				try
				{
					var aktarimYaniti = Program.islemServis.ExplorerdanAl(
						new IslemIstek
						{
							Islem = new Islem
							{
								Alici = aliciAdres,
								Tutar = tutar,
							}
						});
					if (aktarimYaniti != null && aktarimYaniti.Durum == true) sonuc = true;
					else return sonuc = false;
				}
				catch
				{
					throw;
				}
			}
			return sonuc;
		}
	}
}
