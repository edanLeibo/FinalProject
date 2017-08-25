using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EX5.Models;
using FinalProject.Dal;

namespace EX5.Controllers
{
    public class BusinessesController : Controller
    {
        private GeneralDbContext db = new GeneralDbContext();

        [Authorize]
        public ActionResult Admin()
        {
            return View(db.DBBusiness.ToList());
        }

        // GET: Businesses
        public ActionResult Index(string BusinessName,string Type, string StreetAddress, string City)
        {
            var Bussinesses = from s in db.DBBusiness select s;
            if (!String.IsNullOrEmpty(BusinessName))
            {
                Bussinesses = Bussinesses.Where(s => s.BusinessName.ToLower().Contains(BusinessName.ToLower()));
            }
            if (!String.IsNullOrEmpty(Type))
            {
                Bussinesses = Bussinesses.Where(s => s.Type.ToLower().Contains(Type.ToLower()));
            }
            if (!String.IsNullOrEmpty(StreetAddress))
            {
                Bussinesses = Bussinesses.Where(s => s.StreetAddress.ToLower().Contains(StreetAddress.ToLower()));
            }
            if (!String.IsNullOrEmpty(City))
            {
                Bussinesses = Bussinesses.Where(s => s.City.ToLower().Contains(City.ToLower()));
            }

            return View(Bussinesses);
        }
          
        // GET: Businesses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Business business = db.DBBusiness.Find(id);
            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        // GET: Businesses/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Businesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,BusinessName,Type,Owner,PhoneNumber,Address,Website,Description,AVGrank,Photo,Video")] Business business)
        {
            if (ModelState.IsValid)
            {
                db.DBBusiness.Add(business);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(business);
        }

        // GET: Businesses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Business business = db.DBBusiness.Find(id);
            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        // POST: Businesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,BusinessName,Type,Owner,PhoneNumber,StreetAddress,City,Website,Description,AVGrank,Photo,Video")] Business business)
        {
            if (ModelState.IsValid)
            {
                db.Entry(business).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(business);
        }

        // GET: Businesses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Business business = db.DBBusiness.Find(id);
            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        // POST: Businesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Business business = db.DBBusiness.Find(id);
            db.DBBusiness.Remove(business);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult GiveRank(int id, int rank)
        {
            Business business = db.DBBusiness.Find(id);
            int size = db.DBBusiness.Count();
            double newRank = (size * business.AVGrank + rank) / (size + 1);
            business.AVGrank = Convert.ToDouble(String.Format("{0:0.00}", newRank));
            db.SaveChanges();
            return Json(new { message= "ok"});
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
