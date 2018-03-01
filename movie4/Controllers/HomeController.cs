using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace movie4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //CheckOut
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

        public ActionResult CheckOut()
        {
            return View();
        }
    }
}