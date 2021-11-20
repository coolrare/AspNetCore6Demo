using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class CourseInstructorCreateModelValidator
        : AbstractValidator<CourseInstructorCreateModel>
    {
        public CourseInstructorCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
