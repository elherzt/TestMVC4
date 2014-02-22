using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestForGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página de descripción de la aplicación.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contacto.";

            return View();
        }

        public ActionResult Saludo()
        {
            

            return View();
        }

        public ActionResult Welcome()
        {


            return View();
        }

        public ActionResult Another()
        {


            return View();
        }

        public ActionResult Emigdio()
        {
            return View();
        }

    }
}
