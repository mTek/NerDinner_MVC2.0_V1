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


            string strDinners = "";
            string strUpComingDinners = "";
            DinnerRepository dRP = new DinnerRepository();

            Dinner newDinner = new Dinner();
            newDinner.Title = "Anoter Dinner at " + DateTime.Now.AddMinutes(2).ToString();
            newDinner.Description = "Description of Anoter Dinner";
            newDinner.EventDate = DateTime.Now.AddMinutes(30);
            newDinner.HostedBy = "MK";
            newDinner.Address = "Blackburn";
            newDinner.ContactPhone = "123456789";
            newDinner.Country = "UK";
            
            newDinner.Latitude = 53.750353;
            newDinner.Longitude = -2.482524;

            dRP.Add(newDinner);

            Dinner dinner5 = dRP.GetDinner(5);
            if (dinner5 != null)
            {
                RSVP rsvp = new RSVP();
                rsvp.AttendeeName = "Mr. A";
                dinner5.RSVPs.Add(rsvp);
            }
            dRP.Save();



            var udinners = dRP.FindAllDinners();
            
            foreach (Dinner dinner in udinners)
            {
                string strRSVP = "";
                foreach (RSVP r in dinner.RSVPs) 
                {
                    strRSVP = strRSVP + ((strRSVP.Trim()!="")?",":"") + r.AttendeeName;
                }
                strDinners = strDinners + ((strDinners.Trim() != "") ? "<br/>" : "") + dinner.Title + "(" + strRSVP + ")";
            }
            ViewData["Dinners"] = strDinners;

            var upComingDinners = dRP.FindUpcomingDinners();
            
            foreach (Dinner din in upComingDinners)
            {
                    strUpComingDinners = strUpComingDinners + ((strUpComingDinners.Trim() != "") ? "<br/>" : "") + din.Title;
            }
            strUpComingDinners += "</p>";
            ViewData["UpComingDinners"] = strUpComingDinners;

            if (dRP.GetDinner(5) != null)
            {
                dRP.Delete(dRP.GetDinner(5));
            }
            dRP.Save();

            return View();
        }

        

        public ActionResult About()
        {
            return View();
        }
    }
}
