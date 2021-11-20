using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Queries
{
    public static partial class EnrollmentExtensions
    {
        #region Generated Extensions
        public static IQueryable<ContosoUniversity.Data.Entities.Enrollment> ByCourseID(this IQueryable<ContosoUniversity.Data.Entities.Enrollment> queryable, int courseID)
        {
            return queryable.Where(q => q.CourseID == courseID);
        }

        public static ContosoUniversity.Data.Entities.Enrollment GetByKey(this IQueryable<ContosoUniversity.Data.Entities.Enrollment> queryable, int enrollmentID)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.Enrollment> dbSet)
                return dbSet.Find(enrollmentID);

            return queryable.FirstOrDefault(q => q.EnrollmentID == enrollmentID);
        }

        public static ValueTask<ContosoUniversity.Data.Entities.Enrollment> GetByKeyAsync(this IQueryable<ContosoUniversity.Data.Entities.Enrollment> queryable, int enrollmentID)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.Enrollment> dbSet)
                return dbSet.FindAsync(enrollmentID);

            var task = queryable.FirstOrDefaultAsync(q => q.EnrollmentID == enrollmentID);
            return new ValueTask<ContosoUniversity.Data.Entities.Enrollment>(task);
        }

        public static IQueryable<ContosoUniversity.Data.Entities.Enrollment> ByStudentID(this IQueryable<ContosoUniversity.Data.Entities.Enrollment> queryable, int studentID)
        {
            return queryable.Where(q => q.StudentID == studentID);
        }

        #endregion

    }
}
