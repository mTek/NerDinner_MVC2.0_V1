﻿using System;
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
    }
}
