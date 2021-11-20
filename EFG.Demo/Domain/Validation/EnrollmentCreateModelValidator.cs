using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class EnrollmentCreateModelValidator
        : AbstractValidator<EnrollmentCreateModel>
    {
        public EnrollmentCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
