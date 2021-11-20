using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class DepartmentUpdateModelValidator
        : AbstractValidator<DepartmentUpdateModel>
    {
        public DepartmentUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(50);
            #endregion
        }

    }
}
