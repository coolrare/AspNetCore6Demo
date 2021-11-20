using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Queries
{
    public static partial class CourseExtensions
    {
        #region Generated Extensions
        public static ContosoUniversity.Data.Entities.Course GetByKey(this IQueryable<ContosoUniversity.Data.Entities.Course> queryable, int courseID)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.Course> dbSet)
                return dbSet.Find(courseID);

            return queryable.FirstOrDefault(q => q.CourseID == courseID);
        }

        public static ValueTask<ContosoUniversity.Data.Entities.Course> GetByKeyAsync(this IQueryable<ContosoUniversity.Data.Entities.Course> queryable, int courseID)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.Course> dbSet)
                return dbSet.FindAsync(courseID);

            var task = queryable.FirstOrDefaultAsync(q => q.CourseID == courseID);
            return new ValueTask<ContosoUniversity.Data.Entities.Course>(task);
        }

        public static IQueryable<ContosoUniversity.Data.Entities.Course> ByDepartmentID(this IQueryable<ContosoUniversity.Data.Entities.Course> queryable, int departmentID)
        {
            return queryable.Where(q => q.DepartmentID == departmentID);
        }

        #endregion

    }
}
