using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class PorsiyonValidator:AbstractValidator<Porsiyon>
    {
        public PorsiyonValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Tanım Bilgisi 50 Karakterden Fazla Olamaz.").NotEmpty().WithMessage("Tanım Bilgisi Boş Geçilemez.");
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat Bilgisi Aralık Dışında.");
            RuleFor(c => c.EkMalzemeCarpan).ScalePrecision(2, 4).WithMessage("Çarpan Bilgisi Aralık Dışında.");
        }
    }
}
