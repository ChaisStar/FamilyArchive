namespace FamilyArchive.Application.Dto.Account
{
    using FluentValidation;

    public class CreateAccountDtoValidator : AbstractValidator<CreateAccountDto>
    {
        public CreateAccountDtoValidator()
        {
            RuleFor(x => x.Username).NotEmpty().Length(5, 50);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty().Length(5, 50);
            RuleFor(x => x.PasswordConfirm).NotEmpty().Length(5, 50).Equal(x => x.Password);
        }
    }
}
