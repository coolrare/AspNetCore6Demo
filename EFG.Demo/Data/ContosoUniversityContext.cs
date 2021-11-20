using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContosoUniversity.Data
{
    public partial class ContosoUniversityContext : DbContext
    {
        public ContosoUniversityContext(DbContextOptions<ContosoUniversityContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<ContosoUniversity.Data.Entities.CourseInstructor> CourseInstructors { get; set; }

        public virtual DbSet<ContosoUniversity.Data.Entities.Course> Courses { get; set; }

        public virtual DbSet<ContosoUniversity.Data.Entities.Department> Departments { get; set; }

        public virtual DbSet<ContosoUniversity.Data.Entities.Enrollment> Enrollments { get; set; }

        public virtual DbSet<ContosoUniversity.Data.Entities.OfficeAssignment> OfficeAssignments { get; set; }

        public virtual DbSet<ContosoUniversity.Data.Entities.Person> People { get; set; }

        public virtual DbSet<ContosoUniversity.Data.Entities.VwCourseStudentCount> VwCourseStudentCounts { get; set; }

        public virtual DbSet<ContosoUniversity.Data.Entities.VwCourseStudents> VwCourseStudents { get; set; }

        public virtual DbSet<ContosoUniversity.Data.Entities.VwDepartmentCourseCount> VwDepartmentCourseCounts { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new ContosoUniversity.Data.Mapping.CourseInstructorMap());
            modelBuilder.ApplyConfiguration(new ContosoUniversity.Data.Mapping.CourseMap());
            modelBuilder.ApplyConfiguration(new ContosoUniversity.Data.Mapping.DepartmentMap());
            modelBuilder.ApplyConfiguration(new ContosoUniversity.Data.Mapping.EnrollmentMap());
            modelBuilder.ApplyConfiguration(new ContosoUniversity.Data.Mapping.OfficeAssignmentMap());
            modelBuilder.ApplyConfiguration(new ContosoUniversity.Data.Mapping.PersonMap());
            modelBuilder.ApplyConfiguration(new ContosoUniversity.Data.Mapping.VwCourseStudentCountMap());
            modelBuilder.ApplyConfiguration(new ContosoUniversity.Data.Mapping.VwCourseStudentsMap());
            modelBuilder.ApplyConfiguration(new ContosoUniversity.Data.Mapping.VwDepartmentCourseCountMap());
            #endregion
        }
    }
}
