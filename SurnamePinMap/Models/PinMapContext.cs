using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SurnamePinMap.Models
{
    public class PinMapContext : DbContext
    {
        public PinMapContext()
            : base("PinMapContext") { }

        public DbSet<Pin> Pins { get; set; }

        public override int SaveChanges()
        {
            var changeSet = ChangeTracker.Entries<IAudit>();
            if (changeSet != null)
            {
                foreach (var entry in changeSet.Where(c => c.State == EntityState.Added))
                {
                    entry.Entity.Created = DateTime.Now;
                }

                foreach (var entry in changeSet.Where(c => c.State == EntityState.Modified))
                {
                    entry.Entity.Modified = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}