using System;
using System.Collections.Generic;

namespace ContosoUniversity.Data.Entities
{
    public partial class Department
    {
        public Department()
        {
            #region Generated Constructor
            Courses = new HashSet<Course>();
            #endregion
        }

        #region Generated Properties
        public int DepartmentID { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Course> Courses { get; set; }

        public virtual Person InstructorPerson { get; set; }

        #endregion

    }
}
