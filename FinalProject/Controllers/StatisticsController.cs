using FinalProject.Dal;
using FinalProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    [Authorize]
    public class StatisticsController : Controller
    {
        private GeneralDbContext db = new GeneralDbContext();
        // GET: Statistics
        public ActionResult ShowStatistics()
        {
            IQueryable<ReviewDateGroup> data = from review in db.DBReview
                                               group review by review.Date into dateGroup
                                               select new ReviewDateGroup()
                                               {
                                                   ReviewDate = dateGroup.Key,
                                                   ReviewCount = dateGroup.Count()
                                               };
            return View(data.ToList());
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}