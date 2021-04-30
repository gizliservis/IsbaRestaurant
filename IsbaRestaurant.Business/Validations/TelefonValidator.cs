using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class TelefonValidator : AbstractValidator<Telefon>
    {
        public TelefonValidator()
        {
            RuleFor(c => c.Telefonu).MaximumLength(20).WithMessage("Telefon Bilgisi 20 Karakterden Fazla Olamaz");

        }
    }
}
