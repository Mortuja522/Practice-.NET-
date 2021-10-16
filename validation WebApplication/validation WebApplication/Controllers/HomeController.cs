using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using validation_WebApplication.Models;

namespace validation_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(String username ,string password)
        {
            DataBase db = new DataBase();
            var User = db.Users.Authenticate(username, password);
            if(User !=null)
            {
                return RedirectToAction("index","Student");
            }
            ViewBag.Message = "invalid username or Password";
            return View();
        }
    }
}