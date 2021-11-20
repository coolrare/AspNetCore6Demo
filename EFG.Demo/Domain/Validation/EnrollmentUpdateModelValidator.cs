using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class EnrollmentUpdateModelValidator
        : AbstractValidator<EnrollmentUpdateModel>
    {
        public EnrollmentUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
