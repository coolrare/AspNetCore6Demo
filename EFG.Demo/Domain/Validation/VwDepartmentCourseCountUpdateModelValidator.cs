using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class VwDepartmentCourseCountUpdateModelValidator
        : AbstractValidator<VwDepartmentCourseCountUpdateModel>
    {
        public VwDepartmentCourseCountUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(50);
            #endregion
        }

    }
}
