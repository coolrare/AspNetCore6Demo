using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Queries
{
    public static partial class OfficeAssignmentExtensions
    {
        #region Generated Extensions
        public static ContosoUniversity.Data.Entities.OfficeAssignment GetByKey(this IQueryable<ContosoUniversity.Data.Entities.OfficeAssignment> queryable, int instructorID)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.OfficeAssignment> dbSet)
                return dbSet.Find(instructorID);

            return queryable.FirstOrDefault(q => q.InstructorID == instructorID);
        }

        public static ValueTask<ContosoUniversity.Data.Entities.OfficeAssignment> GetByKeyAsync(this IQueryable<ContosoUniversity.Data.Entities.OfficeAssignment> queryable, int instructorID)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.OfficeAssignment> dbSet)
                return dbSet.FindAsync(instructorID);

            var task = queryable.FirstOrDefaultAsync(q => q.InstructorID == instructorID);
            return new ValueTask<ContosoUniversity.Data.Entities.OfficeAssignment>(task);
        }

        #endregion

    }
}
