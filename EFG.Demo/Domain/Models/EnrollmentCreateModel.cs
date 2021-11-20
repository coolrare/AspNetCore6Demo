using System;
using System.Collections.Generic;

namespace ContosoUniversity.Domain.Models
{
    public partial class EnrollmentCreateModel
    {
        #region Generated Properties
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public int? Grade { get; set; }

        #endregion

    }
}
