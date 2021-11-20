using System;
using System.Collections.Generic;

namespace ContosoUniversity.Domain.Models
{
    public partial class VwCourseStudentCountReadModel
    {
        #region Generated Properties
        public int? DepartmentID { get; set; }

        public string Name { get; set; }

        public int CourseID { get; set; }

        public string Title { get; set; }

        public int? StudentCount { get; set; }

        #endregion

    }
}
