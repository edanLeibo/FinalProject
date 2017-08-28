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
        // GET: Chart
        public ActionResult Index()
        {
            ReviewDateGroup objProductModel = new ReviewDateGroup();
            objProductModel.ReviewCountData = new ReviewCount();
            objProductModel.ReviewCountData = GetChartData();
            objProductModel.Title = "Month";
            objProductModel.CountTitle = "Review Count";
            
            return View(objProductModel);



            //return View();
        }

        public ReviewCount GetChartData()
        {
            try
            {
                ArrayList xValue = new ArrayList();
                ArrayList yValue = new ArrayList();
                DateTime PreviousYear = DateTime.Now.AddYears(-1);
                var dBReview = db.DBReview.GroupBy(x => x.Date.Month).Select(x => new ReviewDateGroup { month = x.Key, ReviewCount = x.Count() });
                string[] _Month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                dBReview.ToList().ForEach(x => xValue.Add(x.month));
                dBReview.ToList().ForEach(x => yValue.Add(x.ReviewCount));

                var strings = new ArrayList();
                var xV = xValue.Cast<Int32>().ToArray();
                var yV = yValue.Cast<Int32>().ToArray();
                ReviewCount objproduct = new ReviewCount();
                //we can replace this code with database data.Where(w => w.Date.Year == PreviousYear.Year)///.Where(w => w.Date.Year == PreviousYear.Year)
                string strx = string.Join(",", xV);
                string stry = string.Join(",", yV);
                objproduct.Month = strx;//"2009,2010,2011,2012,2013,2014";// string.Join(",", xV);//
                objproduct.Count = stry; //"2000,1000,3000,1500,2300,500"; //string.Join(",", yV);//
                return objproduct;
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }
        //public ActionResult ChartData()
        //{
        //    try
        //    {
        //        ArrayList xValue = new ArrayList();
        //        ArrayList yValue = new ArrayList();
        //        DateTime  PreviousYear = DateTime.Now.AddYears(-1);
        //        var dBReview = db.DBReview.Where(w => w.Date.Year == PreviousYear.Year).GroupBy(x => x.Date.Month).Select(x => new ReviewDateGroup { month = x.Key, ReviewCount = x.Count() });
        //        string[] _Month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        //        dBReview.ToList().ForEach(x => xValue.Add(_Month[x.month - 1]));
        //        dBReview.ToList().ForEach(x => yValue.Add(x.ReviewCount));

        //        new Chart(width: 500, height: 400, theme: ChartTheme.Vanilla3D)
        //            .AddTitle("Yealy Review Chart")
        //            .AddSeries("Default", chartType: "Bar", xValue: xValue, yValues: yValue)
        //            .Write("bmp");

        //    }
        //    catch(Exception ex)
        //    {

        //    }
        //    return null;

        //}
        // GET: Chart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Chart/Create
        public ActionResult Create()
        {
            return View();
        }

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

        // GET: Chart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

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

        // GET: Chart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

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
