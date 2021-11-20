using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class CourseUpdateModelValidator
        : AbstractValidator<CourseUpdateModel>
    {
        public CourseUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(50);
            #endregion
        }

    }
}
