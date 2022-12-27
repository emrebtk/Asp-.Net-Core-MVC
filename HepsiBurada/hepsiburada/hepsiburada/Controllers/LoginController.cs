
using hepsiburada.Entity;
using hepsiburada.Business;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace hepsiburada.Controllers
{
    public class LoginController : Controller
    {
        public BaseController bs = new BaseController();
        public void ayarlar()
        {
         
        }
        public IActionResult Index()
        {
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Admin model)
        {

            var adminuser = bs.db.Admins.FirstOrDefault(x => x.Name == model.Name && x.pass == model.pass);
            ViewBag.Name = adminuser.Name;
            if (adminuser != null)
            {

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, model.Name));
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
               
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

    }
    }

