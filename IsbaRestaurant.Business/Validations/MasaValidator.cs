using FluentValidation;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class MasaValidator : AbstractValidator<Masa>
    {
        public MasaValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Masa Adı 50 Karakterden Fazla Olamaz");
        }
    }
}
