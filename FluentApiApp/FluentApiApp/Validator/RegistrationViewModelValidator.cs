using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentApiApp.Models;
using FluentValidation;

namespace FluentApiApp.Validator
{
    public class RegistrationViewModelValidator : AbstractValidator<RegistrationViewModel>
    {
        public RegistrationViewModelValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name boş geçilemez");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LAst name boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("email boş geçilemez");
        }
    }
}
