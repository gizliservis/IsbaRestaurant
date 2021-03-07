using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Validations
{
    public class EkMalzemeValidator:AbstractValidator<EkMalzeme>
    {
        public EkMalzemeValidator()
        {
            RuleFor(c => c.EkmalzemeAdi).MaximumLength(50).WithMessage("Adı Alanı 50 Karakterden Fazla Olamaz.").NotEmpty().WithMessage("Adı Alanı Boş Geçilemez.");
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat Bilgisi Aralık Dışında.");
        }
    }
}
