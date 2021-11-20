using System;
using System.Collections.Generic;

namespace ContosoUniversity.Domain.Models
{
    public partial class PersonCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        public string Discriminator { get; set; }

        #endregion

    }
}
