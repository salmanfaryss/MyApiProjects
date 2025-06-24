using FluentValidation;
using WebUI.Dtos.GuestDto;

namespace WebUI.ValidationRules
{
    public class GuestValidator : AbstractValidator<CreateGuestDto>
    {
        public GuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez");
          
        }
    }
}
