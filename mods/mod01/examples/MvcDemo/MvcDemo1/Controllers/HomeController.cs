using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo1.Controllers
{
    public class HomeController : Controller
    {

        
        public ActionResult Welcome(string name, int times = 0)
        {
            ViewBag.Name = name;
            ViewBag.Times = times;

            return View();
        }

        [HttpPost]
        public string Test(int id = 0) {
            if (id == 1) {
                return "uno";
            }

            return "cero";
        }

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

        

    }
}