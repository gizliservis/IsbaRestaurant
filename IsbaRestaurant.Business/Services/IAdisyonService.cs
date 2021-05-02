using IsbaRestaurant.Business.Services.Base;
using IsbaRestaurant.Entities.Dtos;
using IsbaRestaurant.Entities.Dtos.Mutfak;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;

namespace IsbaRestaurant.Business.Services
{
    public interface IAdisyonService : IBaseService<Adisyon>
    {
        AdisyonToplamDto AdisyonToplamGetir();
        List<AdisyonHareketDto> AdisyonHareketGetir(DateTime tarih1,DateTime tarih2);
        List<MutfakAdisyonHareketDto> MutfakAdisyonHareketGetir();
        List<MutfakUrunHareketDto> MutfakUrunHareketGetir(Guid adisyonId);
        List<MutfakEkMalzemeDto> MutfakEkMalzemeHareketGetir(Guid urunHareketId);

    }
}
