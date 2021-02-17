using IsbaRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Entities.Tables
{
   public class EkMalzeme:EntityBase
    {
        public string EkmalzemeAdi { get; set; }
        public decimal Fiyat { get; set; }
        public Guid UrunId { get; set; }
        public virtual Urun Urun { get; set; }

    }
}
