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
            var dinners = dinnerRepository.FindUpcomingDinners().ToList();
            return View(dinners);
        }

        //
        // GET: /Dinners/2

        public ActionResult Details(int id)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);
            if (dinner == null)
                return View("NotFound");            
            else
                return View(dinner);
        }

        //
        // GET: /Dinners/Edit/2

        public ActionResult Edit(int id)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);
            return View(dinner);
        }

        //
        // POST: /Dinners/Edit/2

        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection formValues) {
        //Dinner dinner = dinnerRepository.GetDinner(id);
        //try
        //{
        //    TryUpdateModel(dinner);
        //}
        //catch (Exception ex)
        //{
        //    string msg = ex.Message + "\n" + ex.InnerException.Message;
        //}
        //dinnerRepository.Save();
        //return RedirectToAction("Details", new { id = dinner.DinnerID });
        //}
        [HttpPost]
        public ActionResult Edit(int id, FormCollection formValues)
        {
            //Dinner dinner2 = ;


            Dinner dinner = dinnerRepository.GetDinner(id);

            if (TryUpdateModel(dinner))
            {
                dinnerRepository.Save();
                return RedirectToAction("Details", new { id = dinner.DinnerID });
            }
            return View(dinner);
            
        }
    }
}
