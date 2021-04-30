using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class EkMalzemeHareketValidator : AbstractValidator<EkMalzemeHareket>
    {
        public EkMalzemeHareketValidator()
        {
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat Alanı belirtilen Aralıkta Değil");

        }
    }
}
