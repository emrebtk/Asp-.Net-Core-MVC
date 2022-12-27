using hepsiburada.Entity;
using hepsiburada.DataAccess;
using hepsiburada.Business;
using Microsoft.AspNetCore.Mvc;

namespace hepsiburada.Controllers
{
    public class UsersController : Controller
    {
        public HContext db;
        public void ayarlar()
        {
            
            
        }
        public IActionResult Index()
        {
            ayarlar();
            return View();
        }
        [HttpPost]
        public IActionResult Index(User model)
        {
            ayarlar();
            try
            {

                db.Users.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }

        }
        public IActionResult Login()
        {
            ayarlar();
            return View();
        }
        [HttpPost]
        public IActionResult Login(string mail,string pass)
        {
            ayarlar();
            var us = db.Users.FirstOrDefault(u => u.Mail == mail && u.Pass ==pass);
            if (mail != null)
            {
             
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }

        }
    }
}
