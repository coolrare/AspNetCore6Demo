using System;
using FluentValidation;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Validation
{
    public partial class PersonUpdateModelValidator
        : AbstractValidator<PersonUpdateModel>
    {
        public PersonUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MaximumLength(50);
            RuleFor(p => p.Discriminator).NotEmpty();
            RuleFor(p => p.Discriminator).MaximumLength(128);
            #endregion
        }

    }
}
