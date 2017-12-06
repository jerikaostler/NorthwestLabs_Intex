using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class CustomerPortalController : Controller
    {
        // GET: CustomerPortal
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
    }
}