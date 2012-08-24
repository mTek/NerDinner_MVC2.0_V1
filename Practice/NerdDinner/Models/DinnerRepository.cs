using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NerdDinner.Models
{
    public class DinnerRepository
    {
        private NerdDinnerEntities entities = new NerdDinnerEntities();

        public IQueryable<Dinner> FindAllDinners()
        {
            return entities.Dinners;
        }
        public IQueryable<Dinner> FindUpcomingDinners()
        {
            return from dinner in entities.Dinners
                   where dinner.EventDate > DateTime.Now
                   orderby dinner.EventDate
                   select dinner;
            
            //return entities.Dinners.Select(d => d.EventDate > DateTime.Now);
        }
    }
}