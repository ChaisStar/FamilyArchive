namespace FamilyArchive.Application.Dto.Account
{
    using FluentValidation;

    public class LoginDtoVaidator : AbstractValidator<LoginDto>
    {
        public LoginDtoVaidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username should not be empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password should not be empty");
        }
    }
}
