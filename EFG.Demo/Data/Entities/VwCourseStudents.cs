using System;
using System.Collections.Generic;

namespace ContosoUniversity.Data.Entities
{
    public partial class VwCourseStudents
    {
        public VwCourseStudents()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int? DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public int CourseID { get; set; }

        public string CourseTitle { get; set; }

        public int? StudentID { get; set; }

        public string StudentName { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
