using FluentValidation;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Business.Validations
{
    public class EkMalzemeHareketValidator:AbstractValidator<EkMalzemeHareket>
    {
        public EkMalzemeHareketValidator()
        {
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat Alanı belirtilen Aralıkta Değil");

        }
    }
}
