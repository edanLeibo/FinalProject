using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject.Dal;
using FinalProject.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace FinalProject.Controllers
{
    public class OfficesController : Controller
    {
        private GeneralDbContext db = new GeneralDbContext();

        // GET: Offices
        public ActionResult Index(string Street, string city, string manager)
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

        // GET: Offices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Office office = db.DBOffice.Find(id);
            if (office == null)
            {
                return HttpNotFound();
            }
            return View(office);
        }

        // GET: Offices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Offices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OfficeID,BusinessName,City,Street,HouseNumber,Latitude,Longitude,Owner,Manager")] Office office)
        {
            if (ModelState.IsValid)
            {
                db.DBOffice.Add(office);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(office);
        }

        // GET: Offices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Office office = db.DBOffice.Find(id);
            if (office == null)
            {
                return HttpNotFound();
            }
            return View(office);
        }

        // POST: Offices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OfficeID,BusinessName,City,Street,HouseNumber,Latitude,Longitude,Owner,Manager")] Office office)
        {
            if (ModelState.IsValid)
            {
                db.Entry(office).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(office);
        }

        // GET: Offices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Office office = db.DBOffice.Find(id);
            if (office == null)
            {
                return HttpNotFound();
            }
            return View(office);
        }

        // POST: Offices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Office office = db.DBOffice.Find(id);
            db.DBOffice.Remove(office);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
