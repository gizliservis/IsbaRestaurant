using IsbaRestaurant.Entities.Enums;
using IsbaRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Entities.Tables
{
   public class Tanim:EntityBase
    {
        public string Adi { get; set; }
        public TanimTip TanimTip { get; set; }

    }
}
