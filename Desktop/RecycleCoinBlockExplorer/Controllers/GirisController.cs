using Microsoft.AspNetCore.Mvc;
using RecycleCoinBlockExplorer.Data;
using RecycleCoinBlockExplorer.Models.Entity;

namespace RecycleCoinBlockExplorer.Controllers
{
    public class GirisController : Controller
    {
        DataContext _context;

        public IActionResult Index(/*DataContext context*/)
        {
            //_context= context;
            return View();
        }

        [HttpPost]
        public ActionResult Giris(Kisi k)
        {
            //var bilgiler = _context.Kisiler.FirstOrDefault(_ => _.Adi == k.Adi && _.Sifre == k.Sifre);
            if (true)
            {

                //System.Web.Security.FormsAuthentication.SetAuthCookie(bilgiler.kullanici, false);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}
