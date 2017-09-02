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

        [Authorize]
        // GET: Businesses
        public ActionResult Index(string BusinessName, string Category, string StreetAddress, string City)
        {
            var Bussinesses1 = (from s in db.DBBusiness select s).ToList();

            var Bussinesses = from s in Bussinesses1
                              select new Business()
                              {
                                  BusinessID = s.BusinessID,
                                  BusinessName = s.BusinessName,
                                  Owner = s.Owner,
                                  PhoneNumber = s.PhoneNumber,
                                  StreetAddress = s.StreetAddress,
                                  City = s.City,
                                  Website = s.Website,
                                  Description = s.Description,
                                  AVGrank = s.AVGrank,
                                  CategoryID = s.CategoryID,
                                  Category = db.DBCategories.Where(x => x.CategoryID == s.CategoryID).FirstOrDefault()
                              };
            if (!String.IsNullOrEmpty(BusinessName))
            {
                Bussinesses = Bussinesses.Where(s => s.BusinessName.ToLower().Contains(BusinessName.ToLower()));
            }
            if (!String.IsNullOrEmpty(Category))
            {
                Bussinesses = Bussinesses.Where(s => s.Category.CategoryName.ToLower().Contains(Category.ToLower()));
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

        [Authorize]
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

        [Authorize]
        // GET: Businesses/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.DBCategories.ToList(), "CategoryID", "CategoryName");
            return View();
        }

        [Authorize]
        // POST: Businesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,BusinessName,CategoryID,Type,Owner,PhoneNumber,Address,Website,Description,StreetAddress,City,AVGrank,Photo,Video")] Business business)
        {
            if (ModelState.IsValid)
            {
                db.DBBusiness.Add(business);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(business);
        }

        [Authorize]
        // GET: Businesses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.CategoryID = new SelectList(db.DBCategories.ToList(), "CategoryID", "CategoryName");
            Business business = db.DBBusiness.Find(id);
            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        [Authorize]
        // POST: Businesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BusinessID,CategoryID,BusinessName,Type,Owner,PhoneNumber,StreetAddress,City,Website,Description,AVGrank,Photo,Video")] Business business)
        {
            if (ModelState.IsValid)
            {
                db.Entry(business).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(business);
        }

        [Authorize]
        // GET: Businesses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Business business = db.DBBusiness.Find(id);
            business.Category = db.DBCategories.Where(x => x.CategoryID == business.CategoryID).FirstOrDefault();
            //var Bussinesses1 = db.DBBusiness.Find(id);

            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        [Authorize]
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

        [Authorize]
        [HttpPost]
        public ActionResult GiveRank(int id, int rank)
        {
            Business business = db.DBBusiness.Find(id);
            int size = db.DBBusiness.Count();
            double newRank = (size * business.AVGrank + rank) / (size + 1);
            business.AVGrank = Convert.ToDouble(String.Format("{0:0.0}", newRank));
            db.SaveChanges();
            return Json(new { AVGrank = business.AVGrank });
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
