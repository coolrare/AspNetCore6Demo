using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi6.Models
{
    public partial class ContosouniversityContext
    {
        public override int SaveChanges()
        {
            var entities = this.ChangeTracker.Entries();

            foreach (var entry in entities)
            {
                if (entry.State == EntityState.Modified)
                {
                    if (entry.Entity is Department)
                    {
                        // TODO: 可以在這裡針對特定實體進行變更記錄
                    }

                    entry.CurrentValues.SetValues(new { ModifiedOn = DateTime.Now });
                }
            }

            return base.SaveChanges();
        }
    }
}