using FinalProject.Dal;
using FinalProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using System.Collections;

namespace FinalProject.Controllers
{
    public class ChartController : Controller
    {
        private GeneralDbContext db = new GeneralDbContext();

        [Authorize]
        // GET: Chart
        public ActionResult Index()
        {
            ReviewDateGroup objProductModel = new ReviewDateGroup();
            objProductModel.ReviewCountData = new ReviewCount();
            objProductModel.ReviewCountData = GetChartData();
            objProductModel.Title = "Months";
            objProductModel.CountTitle = "Review Count";
            
            return View(objProductModel);
        }

        [Authorize]
        public ReviewCount GetChartData()
        {
            try
            {
                ArrayList xValue = new ArrayList();
                ArrayList yValue = new ArrayList();
                var dBReview = db.DBReview.GroupBy(x => x.Date.Month).Select(x => new ReviewDateGroup { month = x.Key, ReviewCount = x.Count() });
                dBReview.ToList().ForEach(x => xValue.Add(x.month));
                dBReview.ToList().ForEach(x => yValue.Add(x.ReviewCount));

                var xV = xValue.Cast<Int32>().ToArray();
                var yV = yValue.Cast<Int32>().ToArray();
                ReviewCount objproduct = new ReviewCount();
                string strx = string.Join(",", xV);
                string stry = string.Join(",", yV);
                objproduct.Month = strx; //"1,2,3,4,5,6...";// string.Join(",", xV);//
                objproduct.Count = stry; //"2000,1000,3000,1500,2300,500"; //string.Join(",", yV);//
                return objproduct;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [Authorize]
        //Data for graph it shows how much Business in each category
        public JsonResult categoriesGraph()
        {

            List<Result> numOfBusinesses = new List<Result>();

            //Perform join to get all relevant categories
            var myQuery = from c in db.DBCategories
                        join b in db.DBBusiness on c.CategoryID equals b.CategoryID
                        select c;

            //Now we group it by category name and count it
            var myGroup = from t in myQuery
                          group t by t.CategoryName into cat
                          select new
                          {
                            CategoryName = cat.Key,
                            amount = cat.Count()
                          };
            //Make it in the right form for the view
            foreach (var item in myGroup)
            {
                Result numBusinesses = new Result();
                numBusinesses.State = item.CategoryName;
                numBusinesses.freq = item.amount;
                numOfBusinesses.Add(numBusinesses);
            }

            return Json(numOfBusinesses, JsonRequestBehavior.AllowGet);
        }

        [Authorize]
        public JsonResult topFiveGraph()
        {

            List<Result> numOfReviews = new List<Result>();

            /*Join by BusinessID*/
            var myQuery = from b in db.DBBusiness
                          join r in db.DBReview on b.BusinessID equals r.BusinessID
                        select b;


            /*now we group it for the graph*/
            var myGroup = from t in myQuery
                        group t by t.BusinessName into cat
                        select new
                        {
                            cName = cat.Key,
                            Num = cat.Count()
                        };

            var myQuery2 = (from y in @myGroup
                         where y.Num >= 1
                         orderby y.Num
                         select y).Take(5);

            foreach (var item in myQuery2)
            {
                Result numReviews = new Result();
                numReviews.State = item.cName;
                numReviews.freq = item.Num;
                numOfReviews.Add(numReviews);
            }

            return Json(numOfReviews, JsonRequestBehavior.AllowGet);
        }

        [Authorize]
        // GET: Chart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [Authorize]
        // GET: Chart/Create
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        // POST: Chart/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        // GET: Chart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        [Authorize]
        // POST: Chart/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        // GET: Chart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        [Authorizes]
        // POST: Chart/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
