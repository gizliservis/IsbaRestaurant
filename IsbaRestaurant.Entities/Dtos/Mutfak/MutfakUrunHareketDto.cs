using IsbaRestaurant.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Entities.Dtos.Mutfak
{
   public class MutfakUrunHareketDto
    {
        public Guid Id { get; set; }
        public Guid AdisyonId { get; set; }
        public UrunHareketTip UrunHareketTip { get; set; }
        public decimal Miktar { get; set; }
        public string UrunAdi { get; set; }
        public string Porsiyon { get; set; }
        public string Birim { get; set; }

    }
}
