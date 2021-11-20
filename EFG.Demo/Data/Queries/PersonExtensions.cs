using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Queries
{
    public static partial class PersonExtensions
    {
        #region Generated Extensions
        public static ContosoUniversity.Data.Entities.Person GetByKey(this IQueryable<ContosoUniversity.Data.Entities.Person> queryable, int id)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.Person> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<ContosoUniversity.Data.Entities.Person> GetByKeyAsync(this IQueryable<ContosoUniversity.Data.Entities.Person> queryable, int id)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.Person> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<ContosoUniversity.Data.Entities.Person>(task);
        }

        #endregion

    }
}
