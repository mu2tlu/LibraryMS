using FluentValidation;

namespace Application.Features.Publishers.Commands.Create;

public class CreatePublisherCommandValidator : AbstractValidator<CreatePublisherCommand>
{
    public CreatePublisherCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().MinimumLength(2).MaximumLength(30).Must(name => char.IsUpper(name[0])).WithMessage("First letter of the name must be uppercase.");  // Bunu setter i�erisinde ctor ile yapadabiliriz.
        RuleFor(c => c.PhoneNumber).NotEmpty().Must(phone => phone.Length == 7 || phone.Length == 10 || phone.Length == 11);
    }
}