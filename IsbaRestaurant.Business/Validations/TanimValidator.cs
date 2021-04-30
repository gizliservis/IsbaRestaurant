using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class TanimValidator : AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Tanım Bilgisi 50 Karakterden Fazla Olamaz.").NotEmpty().WithMessage("Tanım Bilgisi Boş Geçilemez.");
        }
    }
}
