using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class UrunHareketValidator : AbstractValidator<UrunHareket>
    {
        public UrunHareketValidator()
        {
            RuleFor(c => c.Indirim).ScalePrecision(2, 5).WithMessage("İndirim İstenilen Aralıkta Değil.");
            RuleFor(c => c.Miktar).ScalePrecision(3, 8).WithMessage("Miktar İstenilen Aralıkta Değil");
        }
    }
}
