using IsbaRestaurant.Entities.Enums;
using IsbaRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Entities.Tables
{
    public class Musteri : EntityBase
    {
        public MusteriTip MusteriTip { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sirket { get; set; }
        public string KartNo { get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }
        public virtual ICollection<Adres> Adresler { get; set; }
        public virtual ICollection<Adisyon> Adisyonlar { get; set; }


    }
}
