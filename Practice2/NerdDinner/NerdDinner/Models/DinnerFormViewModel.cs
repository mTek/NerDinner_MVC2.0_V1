using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NerdDinner.Models
{
    public class DinnerFormViewModel
    {
        private static string[] _countries = new string[]{
                "UK",
                "USA",
                "Pakistan"
            };
        public SelectList Countries{get; set;}
        public Dinner Dinner { get; set; }
        public DinnerFormViewModel(Dinner dinner)
        {
            
            Countries = new SelectList(_countries, dinner.Country);
            Dinner = dinner;
        }
    }
}