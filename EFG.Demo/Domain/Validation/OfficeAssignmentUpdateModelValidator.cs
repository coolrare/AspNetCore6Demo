using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class OfficeAssignmentUpdateModelValidator
        : AbstractValidator<OfficeAssignmentUpdateModel>
    {
        public OfficeAssignmentUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Location).MaximumLength(50);
            #endregion
        }

    }
}
