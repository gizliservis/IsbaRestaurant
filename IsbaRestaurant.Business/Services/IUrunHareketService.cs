using IsbaRestaurant.Business.Services.Base;
using IsbaRestaurant.Entities.Dtos;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IsbaRestaurant.Business.Services
{
    public interface IUrunHareketService : IBaseService<UrunHareket>
    {
        IEnumerable<UrunHareket> UrunHareketListesiGetir(DateTime baslangicTarihi, DateTime bitisTarihi);
        List<EnCokSatanUrunlerDto> EnCokSatanUrunleriGetir();
    }
}
