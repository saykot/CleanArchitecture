using Application.Commands;
using FluentValidation;

namespace Application.CommandValidators
{
    public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
    {
        public AddProductCommandValidator() 
        {
            RuleFor(c => c.Name)
                .NotNull().WithMessage("NAME_MUST_NOT_NULL")
                .NotEmpty().WithMessage("NAME_MUST_NOT_EMPTY");
        }
    }
}
