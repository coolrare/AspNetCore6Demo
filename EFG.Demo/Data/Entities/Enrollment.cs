using System;
using System.Collections.Generic;

namespace ContosoUniversity.Data.Entities
{
    public partial class Enrollment
    {
        public Enrollment()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public int? Grade { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Course Course { get; set; }

        public virtual Person StudentPerson { get; set; }

        #endregion

    }
}
