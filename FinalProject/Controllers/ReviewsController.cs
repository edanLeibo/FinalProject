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

namespace FinalProject.Controllers
{
    public class ReviewsController : Controller
    {
        private GeneralDbContext db = new GeneralDbContext();

        // GET: Reviews
        public ActionResult Index(string businessName,string author, string description)
        {
            var dBReview = db.DBReview.Include(r => r.Business);
            if (!String.IsNullOrEmpty(businessName))
            {
                dBReview = dBReview.Where(s => s.Business.BusinessName.ToLower().Contains(businessName.ToLower()));
            }
            if (!String.IsNullOrEmpty(author))
            {
                dBReview = dBReview.Where(s => s.Author.ToLower().Contains(author.ToLower()));
            }
            if (!String.IsNullOrEmpty(description))
            {
                dBReview = dBReview.Where(s => s.Description.ToLower().Contains(description.ToLower()));
            }

            return View(dBReview.ToList());
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.DBReview.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        /**
        // GET: Reviews/Create
        public ActionResult Create()
        {
            ViewBag.BusinessID = new SelectList(db.DBBusiness, "BusinessID", "BusinessName");
            return View();
        }
        **/

        // GET: Reviews/Create
        public ActionResult Create(int? id)
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
            ViewBag.BusinessID = new SelectList(db.DBBusiness, "BusinessID", "BusinessName", business.BusinessID);
            return View(); 
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReviewID,Date,Author,Description,BusinessID")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.DBReview.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusinessID = new SelectList(db.DBBusiness, "BusinessID", "BusinessName", review.BusinessID);
            return View(review);
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int? id)
        {
            /**
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.DBReview.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusinessID = new SelectList(db.DBBusiness, "BusinessID", "BusinessName", review.BusinessID);
            return View(review);
    **/
            return Json(id);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReviewID,Date,Author,Description,BusinessID")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusinessID = new SelectList(db.DBBusiness, "BusinessID", "BusinessName", review.BusinessID);
            return View(review);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.DBReview.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = db.DBReview.Find(id);
            db.DBReview.Remove(review);
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
