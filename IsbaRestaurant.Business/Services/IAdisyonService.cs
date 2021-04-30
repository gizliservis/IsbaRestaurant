using IsbaRestaurant.Business.Services.Base;
using IsbaRestaurant.Entities.Dtos;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;

namespace IsbaRestaurant.Business.Services
{
    public interface IAdisyonService : IBaseService<Adisyon>
    {
        AdisyonToplamDto AdisyonToplamGetir();
        List<AdisyonHareketDto> AdisyonHareketGetir(DateTime Tarih);

    }
}
