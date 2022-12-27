using Microsoft.AspNetCore.Mvc;

namespace Deneme1.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sinif()
        {
            return View();
        }

    }
}
