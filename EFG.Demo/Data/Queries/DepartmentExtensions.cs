using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Queries
{
    public static partial class DepartmentExtensions
    {
        #region Generated Extensions
        public static ContosoUniversity.Data.Entities.Department GetByKey(this IQueryable<ContosoUniversity.Data.Entities.Department> queryable, int departmentID)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.Department> dbSet)
                return dbSet.Find(departmentID);

            return queryable.FirstOrDefault(q => q.DepartmentID == departmentID);
        }

        public static ValueTask<ContosoUniversity.Data.Entities.Department> GetByKeyAsync(this IQueryable<ContosoUniversity.Data.Entities.Department> queryable, int departmentID)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.Department> dbSet)
                return dbSet.FindAsync(departmentID);

            var task = queryable.FirstOrDefaultAsync(q => q.DepartmentID == departmentID);
            return new ValueTask<ContosoUniversity.Data.Entities.Department>(task);
        }

        public static IQueryable<ContosoUniversity.Data.Entities.Department> ByInstructorID(this IQueryable<ContosoUniversity.Data.Entities.Department> queryable, int? instructorID)
        {
            return queryable.Where(q => (q.InstructorID == instructorID || (instructorID == null && q.InstructorID == null)));
        }

        #endregion

    }
}
