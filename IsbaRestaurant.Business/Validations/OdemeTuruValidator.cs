using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class OdemeTuruValidator : AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Ödeme Adı 50 Karakterden Fazla Olamaz !!");
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Ödeme Adı Boş Geçilemez !! ");
        }
    }
}
