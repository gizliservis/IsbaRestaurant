using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class MusteriValidator : AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Adı Bilgisi 50 Karakterden Fazla Olamaz");
            RuleFor(c => c.Adi).MaximumLength(50).NotEmpty().WithMessage("Adı Bilgisi Boş Geçilemez");
            RuleFor(c => c.Soyadi).MaximumLength(50).WithMessage("Soyadı Bilgisi 50 Karakterden Fazla Olamaz");
            RuleFor(c => c.KartNo).MaximumLength(20).WithMessage("Kart No Bilgisi 20 Karakterden Fazla Olamaz");
        }
    }
}
