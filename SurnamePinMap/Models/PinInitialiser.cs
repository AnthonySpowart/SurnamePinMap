using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurnamePinMap.Models
{
    public class PinInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<PinMapContext>
    {
        protected override void Seed(PinMapContext context)
        {
            var me = new Pin()
            {
                FirstName = "Anthony",
                LastName = "Spowart",
                Email = "anthony@spowart.com",
                Latitude = 43.64999,
                Longitude = -79.38892
            };
            
            context.Pins.Add(me);

            var dad = new Pin()
            {
                FirstName = "Tony",
                LastName = "Spowart",
                Email = "tony@spowart.com",
                Latitude = -43.53859,
                Longitude = -187.38075
            };

            context.Pins.Add(dad);

            context.SaveChanges();
        }
    }
}