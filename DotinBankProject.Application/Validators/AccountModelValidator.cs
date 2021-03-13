using DotinBankProject.Application.Models;
using FluentValidation;

namespace DotinBankProject.Application.Validators
{
    class AccountModelValidator:AbstractValidator<AccountModel>
    {
        public AccountModelValidator()
        {
            RuleFor(p => p.Id)
                .NotNull()
                .GreaterThan(0)
                .ExclusiveBetween(0, int.MaxValue);
        }
    }
}
