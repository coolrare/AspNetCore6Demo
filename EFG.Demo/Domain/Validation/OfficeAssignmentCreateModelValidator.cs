using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class OfficeAssignmentCreateModelValidator
        : AbstractValidator<OfficeAssignmentCreateModel>
    {
        public OfficeAssignmentCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Location).MaximumLength(50);
            #endregion
        }

    }
}
