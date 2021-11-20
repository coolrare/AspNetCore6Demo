using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class CourseInstructorUpdateModelValidator
        : AbstractValidator<CourseInstructorUpdateModel>
    {
        public CourseInstructorUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
