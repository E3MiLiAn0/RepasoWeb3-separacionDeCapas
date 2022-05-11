using Microsoft.AspNetCore.Mvc;

namespace ExamenWeb3.Controllers
{
    public class PresentacionWeb3 : Controller
    {
        // GET: PresentacionWeb3
        public ActionResult Bienvenidxs()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }
    }
}
