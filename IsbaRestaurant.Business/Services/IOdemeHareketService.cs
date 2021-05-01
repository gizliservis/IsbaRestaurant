using IsbaRestaurant.Business.Services.Base;
using IsbaRestaurant.Entities.Dtos;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;

namespace IsbaRestaurant.Business.Services
{
    public interface IOdemeHareketService : IBaseService<OdemeHareket>
    {
        IEnumerable<OdemeHareket> OdemeHareketListesiGetir(DateTime baslangicTarihi, DateTime bitisTarihi);
        List<HaftalikKazancDto> HaftalikKazancıGetir();
        List<AylikKazancDto> AylikKazancıGetir();
        List<YillikKazancDto> YillikKazancıGetir();
    }
}
