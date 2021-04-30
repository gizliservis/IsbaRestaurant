using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class AdisyonValidator : AbstractValidator<Adisyon>
    {
        public AdisyonValidator()
        {
            RuleFor(c => c.Tutar).ScalePrecision(2, 10).WithMessage("Tutar İstenilen Aralıkta Değil.");
            RuleFor(c => c.Indirim).ScalePrecision(2, 5).WithMessage("İndirim İstenilen Aralıkta Değil.");
        }
    }
}
