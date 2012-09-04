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
            return View(dinnerRepository.FindUpcomingDinners());
        }

        //
        // GET: /Dinners/Details/2

        public ActionResult Details(int id)
        {
            return View(dinnerRepository.GetDinner(id));
        }

        //
        // GET: /Dinners/Details/2

        public ActionResult Edit(int id)
        {
            return View(dinnerRepository.GetDinner(id));
        }

        //
        // POST: /Dinners/Details/2
        [HttpPost]
        public ActionResult Edit(int id, FormCollection form)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);
            if (TryUpdateModel(dinner))
            {
                dinnerRepository.Save();
                return RedirectToAction("Details", new { id=dinner.DinnerID });
            }
            return View(dinner);

            //bool result = TryUpdateModel(dinner);
            //if (result)
            //{
            //    dinnerRepository.Save();
            //    return View("Details", dinner);
            //}
            //else
            //{
            //    return View("Error");
            //}
        }


    }
}
