using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WorkOrders()
        {
            return View();
        }

        public ActionResult AssayTests()
        {
            return View();
        }

        public ActionResult RequestForQuote()
        {
            return View();
        }

        public ActionResult ReceiptLog()
        {
            return View();
        }

        public  ActionResult Reports()
        {
            return View();
        }
    }
}