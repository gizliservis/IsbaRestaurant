using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Entities.Enums
{
   public enum TelefonAdresTip
    {
        [Description("Ev")]
        Ev,
        [Description("İş")]
        Is,
        [Description("Diğer")]
        Diger
    }
}
