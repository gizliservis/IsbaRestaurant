using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class UrunValidator : AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez.").MaximumLength(50).WithMessage("Ürün Adı 50 Karakterden Fazla Girilemez.");
            RuleFor(c => c.Barkod).MaximumLength(20).WithMessage("Barkod Bilgisi 20 Karakterden Fazla Girilemez.").NotEmpty().WithMessage("Barkod Boş Geçilemez.");

        }
    }
}
