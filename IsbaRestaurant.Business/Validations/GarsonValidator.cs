using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class GarsonValidator : AbstractValidator<Garson>
    {
        public GarsonValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Adi Alanı 50 Karakterden Fazla Olamaz");
            RuleFor(c => c.Soyadi).MaximumLength(50).WithMessage("Soyadi Alanı 50 Karakterden Fazla Olamaz");

        }
    }
}
