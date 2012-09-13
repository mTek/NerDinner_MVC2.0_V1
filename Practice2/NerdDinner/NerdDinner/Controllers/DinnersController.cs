using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdDinner.Models;
namespace NerdDinner.Controllers
{
    public class DinnersController : Controller
    {
        DinnerRepository dinnerRepository = new DinnerRepository();

        //
        // GET: /Dinners/

        public ActionResult Index()
        {
            return View(dinnerRepository.FindUpcomingDinners().ToList());
        }

        //
        // GET: /Dinners/Details/2

        public ActionResult Details(int id)
        {
            return View(dinnerRepository.GetDinner(id));
        }


        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //Actions using ViewModel Pattern Start
        
        //
        // GET: /Dinners/Edit/2
        public ActionResult Edit(int id)
        {
            DinnerFormViewModel dinnerView = new DinnerFormViewModel(dinnerRepository.GetDinner(id));
            return View(dinnerView);
        }
        //
        // POST: /Dinners/Edit/2
        [HttpPost]
        public ActionResult Edit(int id, FormCollection form)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);
            if(TryUpdateModel(dinner,"Dinner")) {
            dinnerRepository.Save();
            return RedirectToAction("Details", new { id=dinner.DinnerID });
            }
            return View(new DinnerFormViewModel(dinner));
        }

        //
        // GET: /Dinners/Create/
        public ActionResult Create()
        {
            Dinner dinner = new Dinner { EventDate = DateTime.Now.AddDays(7) };
            return View(new DinnerFormViewModel(dinner));
        }

        //
        //POST
        public ActionResult Create(Dinner dinner)
        {
            if (ModelState.IsValid)
            {
                dinner.HostedBy = "Someone";
                dinnerRepository.Add(dinner);
                dinnerRepository.Save();
                return RedirectToAction("Details", new { id = dinner.DinnerID });

            }
            return View(new DinnerFormViewModel(dinner));
        }

        //Actions using ViewModel Pattern End
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@




        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //Original Edit
        //
        // GET: /Dinners/Edit/2

        
        //public ActionResult Edit(int id)
        //{
        //    Dinner dinner = dinnerRepository.GetDinner(id);
        //    string[] countries = new string[]{
        //        "UK",
        //        "USA",
        //        "Pakistan"
        //    };
        //    ViewData["Countries"] = new SelectList(countries, dinner.Country); 
        //    return View(dinner);
        //}

        //
        // POST: /Dinners/Edit/2
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection form)
        //{
        //    Dinner dinner = dinnerRepository.GetDinner(id);

        //    string[] allowedProperties = new[] { "Title", "Description", "ContactPhone", "Country", "EventDate", "Latitude", "Longitude" };

            

        //    if (TryUpdateModel(dinner, allowedProperties))
        //    {
        //        dinnerRepository.Save();
        //        return RedirectToAction("Details", new { id=dinner.DinnerID });
        //    }

        //    string[] countries = new string[]{
        //        "UK",
        //        "USA",
        //        "Pakistan"
        //    };
        //    ViewData["Countries"] = new SelectList(countries, dinner.Country); 

        //    return View(dinner);

        //}
        


        //
        // GET: /Dinner/Create/

        //public ActionResult Create()
        //{
        //    Dinner dinner = new Dinner(){
        //    EventDate = DateTime.Now.AddDays(7)
        //    };
        //    return View(dinner); 
        //}

        //
        // POST: /Dinner/Create/
        //[HttpPost]
        //public ActionResult Create(FormCollection form)
        //{
        //    Dinner dinner = new Dinner();
        //    if (TryUpdateModel(dinner))
        //    {
        //        dinner.HostedBy = "Someone";
        //        dinnerRepository.Add(dinner);
        //        dinnerRepository.Save();
        //        return RedirectToAction("Details", new { id=dinner.DinnerID });
        //    }
        //    return View(dinner);
        //}

        //
        // POST: /Dinner/Create/
        //[HttpPost]
        //public ActionResult Create(Dinner dinner)
        //{
        //    //Dinner dinner = new Dinner();
        //    if (ModelState.IsValid)
        //    {
        //        dinner.HostedBy = "Someone";
        //        dinnerRepository.Add(dinner);
        //        dinnerRepository.Save();
        //        return RedirectToAction("Details", new { id = dinner.DinnerID });
        //    }
        //    return View(dinner);
        //}

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@



        //
        // GET: /Dinner/Delete/2
        public ActionResult Delete(int id)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);
            if (dinner == null)
            {
                return View("Error");
            }
            else
            {
                return View(dinner);
            }
        }


        //
        // POST: /Dinner/Delete/2
        [HttpPost]
        public ActionResult Delete(int id, string confirmbutton)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);
            if (dinner == null)
            { 
                return View("Error");
            }
            if (confirmbutton.ToUpper() == "DELETE")
            {
                dinnerRepository.Delete(dinner);
                dinnerRepository.Save();
                return View("Deleted");
            }
            else
            {
                return View(dinner);
            }
        }

    }
}
