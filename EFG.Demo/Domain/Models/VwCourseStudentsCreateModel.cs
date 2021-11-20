using System;
using System.Collections.Generic;

namespace ContosoUniversity.Domain.Models
{
    public partial class VwCourseStudentsCreateModel
    {
        #region Generated Properties
        public int? DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public int CourseID { get; set; }

        public string CourseTitle { get; set; }

        public int? StudentID { get; set; }

        public string StudentName { get; set; }

        #endregion

    }
}
