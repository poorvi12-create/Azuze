using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebAppG3AzureProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Poorvi Raut's page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My Contact information.";

            return View();
        }
    }
}