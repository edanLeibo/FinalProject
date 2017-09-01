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

        public ActionResult Contact(string Street, string city, string manager)
        {
            var Offices = from o in db.DBOffice select o;
            if (!String.IsNullOrEmpty(Street))
            {
                Offices = Offices.Where(s => s.Street.ToLower().Contains(Street.ToLower()));
            }
            if (!String.IsNullOrEmpty(city))
            {
                Offices = Offices.Where(s => s.City.ToLower().Contains(city.ToLower()));
            }
            if (!String.IsNullOrEmpty(manager))
            {
                Offices = Offices.Where(s => s.Manager.ToLower().Contains(manager.ToLower()));
            }

            return View(Offices);
        }
    }
}