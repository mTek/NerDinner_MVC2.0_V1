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
        // GET: /Dinners/Edit/2

        public ActionResult Edit(int id)
        {
            return View(dinnerRepository.GetDinner(id));
        }

        //
        // POST: /Dinners/Edit/2
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

        }

        //
        // GET: /Dinner/Create/

        public ActionResult Create()
        {
            Dinner dinner = new Dinner(){
            EventDate = DateTime.Now.AddDays(7)
            };
            return View(dinner); 
        }

        //
        // POST: /Dinner/Create/
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            Dinner dinner = new Dinner();
            if (TryUpdateModel(dinner))
            {
                dinner.HostedBy = "Someone";
                dinnerRepository.Add(dinner);
                dinnerRepository.Save();
                return RedirectToAction("Details", new { id=dinner.DinnerID });
            }
            return View(dinner);
        }

    }
}
