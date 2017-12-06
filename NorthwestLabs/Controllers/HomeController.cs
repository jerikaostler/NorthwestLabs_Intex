using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NorthwestLabs.Controllers
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
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String UserName = form["UserName"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(UserName, "Customer") && (string.Equals(password, "test")))
            {
                FormsAuthentication.SetAuthCookie(UserName, rememberMe);

                return RedirectToAction("Index", "Customer");

            }
            else if (string.Equals(UserName, "Employee") && (string.Equals(password, "test")))
            {
                FormsAuthentication.SetAuthCookie(UserName, rememberMe);

                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View();
            }
        }
    }
}