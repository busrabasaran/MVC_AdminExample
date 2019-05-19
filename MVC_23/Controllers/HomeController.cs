using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_23.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.SayfaninBasligi = "Bu benim sayfamın başlığı";

            string rol = "Kargocu";

            if (rol=="Kargocu")
            {
                ViewBag.AspLinkVisibility = "Hidden";
            }
            else
            {
                ViewBag.AspLinkVisibility = "Visible";
            }

            
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