using FinalProject.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EX5.Controllers
{
    public class HomeController : Controller
    {
        private GeneralDbContext db = new GeneralDbContext();
    
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

            return View(db.DBOffice);
        }
    }
}