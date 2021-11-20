using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class VwCourseStudentsCreateModelValidator
        : AbstractValidator<VwCourseStudentsCreateModel>
    {
        public VwCourseStudentsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.DepartmentName).MaximumLength(50);
            RuleFor(p => p.CourseTitle).MaximumLength(50);
            RuleFor(p => p.StudentName).MaximumLength(101);
            #endregion
        }

    }
}
