using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdDinner.Models;
using System.Data.Entity;
namespace NerdDinner.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            NerdDinnerEntities entities = new NerdDinnerEntities();
            var udinners = entities.Dinners.Single(d => d.DinnerID == 1);
                            //from dinner in entities.Dinners
                            // where dinner.DinnerID = 1 //dinner.EventDate > DateTime.Now
                            // orderby dinner.EventDate
                            // select dinner;

            string strDinners = "";
            strDinners = udinners.Title + "     " + udinners.Description;
            udinners.Description = "New Description";
            entities.SaveChanges();
            var updateddinner = entities.Dinners.Single(d => d.DinnerID == 1);
            strDinners = strDinners + "<br>" + updateddinner.Title + "     " + updateddinner.Description;
            //foreach (Dinner dinner in udinners)
            //{
            //    if (strDinners.Trim() == "")
            //    {
            //        strDinners = dinner.Title;
            //    }
            //    else
            //    {
            //        strDinners = strDinners + dinner.Title;
            //    }
            //}
            ViewData["Dinners"] = strDinners;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
