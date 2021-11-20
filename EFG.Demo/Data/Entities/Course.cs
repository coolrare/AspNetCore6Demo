using System;
using System.Collections.Generic;

namespace ContosoUniversity.Data.Entities
{
    public partial class Course
    {
        public Course()
        {
            #region Generated Constructor
            CourseInstructors = new HashSet<CourseInstructor>();
            Enrollments = new HashSet<Enrollment>();
            #endregion
        }

        #region Generated Properties
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        #endregion

    }
}
