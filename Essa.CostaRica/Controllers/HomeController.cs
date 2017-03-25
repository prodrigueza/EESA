using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Essa.CostaRica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath(ConfigurationManager.AppSettings["CarouselPath"]));
            List<string> list = new List<string>();
            foreach (string item in filePaths)
            {
                list.Add(ConfigurationManager.AppSettings["CarouselPath"].Replace("\\", "/") + "/" + Path.GetFileName(item));
            }
            ViewBag.CarouselPaths = list;
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