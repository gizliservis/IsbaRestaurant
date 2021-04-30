using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class OdemeHareketValidator : AbstractValidator<OdemeHareket>
    {
        public OdemeHareketValidator()
        {
            RuleFor(c => c.Tutar).ScalePrecision(2, 10);
        }
    }
}
