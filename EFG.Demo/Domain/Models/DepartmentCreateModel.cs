using System;
using System.Collections.Generic;

namespace ContosoUniversity.Domain.Models
{
    public partial class DepartmentCreateModel
    {
        #region Generated Properties
        public int DepartmentID { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
