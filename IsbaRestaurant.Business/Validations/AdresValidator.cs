using FluentValidation;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Business.Validations
{
    public class AdresValidator:AbstractValidator<Adres>
    {
        public AdresValidator()
        {
            RuleFor(c => c.Il).MaximumLength(30).WithMessage("İl Bilgisi 30 Karakterden Fazla Olamaz !!");
        }
    }
}
