﻿using IsbaRestaurant.Business.Services.Base;
using IsbaRestaurant.Entities.Dtos;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Business.Services
{
   public interface IAdisyonService:IBaseService<Adisyon>
    {
        AdisyonToplamDto AdisyonToplamGetir();

    }
}
