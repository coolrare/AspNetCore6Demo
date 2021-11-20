using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Queries
{
    public static partial class CourseInstructorExtensions
    {
        #region Generated Extensions
        public static IQueryable<ContosoUniversity.Data.Entities.CourseInstructor> ByCourseID(this IQueryable<ContosoUniversity.Data.Entities.CourseInstructor> queryable, int courseID)
        {
            return queryable.Where(q => q.CourseID == courseID);
        }

        public static ContosoUniversity.Data.Entities.CourseInstructor GetByKey(this IQueryable<ContosoUniversity.Data.Entities.CourseInstructor> queryable, int courseID, int instructorID)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.CourseInstructor> dbSet)
                return dbSet.Find(courseID, instructorID);

            return queryable.FirstOrDefault(q => q.CourseID == courseID
                && q.InstructorID == instructorID);
        }

        public static ValueTask<ContosoUniversity.Data.Entities.CourseInstructor> GetByKeyAsync(this IQueryable<ContosoUniversity.Data.Entities.CourseInstructor> queryable, int courseID, int instructorID)
        {
            if (queryable is DbSet<ContosoUniversity.Data.Entities.CourseInstructor> dbSet)
                return dbSet.FindAsync(courseID, instructorID);

            var task = queryable.FirstOrDefaultAsync(q => q.CourseID == courseID
                && q.InstructorID == instructorID);
            return new ValueTask<ContosoUniversity.Data.Entities.CourseInstructor>(task);
        }

        public static IQueryable<ContosoUniversity.Data.Entities.CourseInstructor> ByInstructorID(this IQueryable<ContosoUniversity.Data.Entities.CourseInstructor> queryable, int instructorID)
        {
            return queryable.Where(q => q.InstructorID == instructorID);
        }

        #endregion

    }
}
