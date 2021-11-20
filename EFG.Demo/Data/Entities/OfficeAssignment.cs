using System;
using System.Collections.Generic;

namespace ContosoUniversity.Data.Entities
{
    public partial class OfficeAssignment
    {
        public OfficeAssignment()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int InstructorID { get; set; }

        public string Location { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Person InstructorPerson { get; set; }

        #endregion

    }
}
