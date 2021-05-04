using FluentValidation;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Business.Validations
{
   public class UrunNotValidator :AbstractValidator<UrunNot>
    {
        public UrunNotValidator()
        {
            RuleFor(c => c.Notu).MaximumLength(100).WithMessage("Notunuz 100 Karakterden Fazla Olamaz");
            RuleFor(c => c.Notu).MaximumLength(100).NotEmpty().WithMessage("Not Alanı Boş Bırakılamaz");
        }
    }
}
