using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Dtos;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace IsbaRestaurant.Business.Managers
{
    public class UrunHareketManager : BaseManager<UrunHareket>, IUrunHareketService
    {
        private RestaurantUnitOfWork _uow;
        public UrunHareketManager(IUnitOfWork uow) : base(uow)
        {
            _uow = (RestaurantUnitOfWork)uow;

        }

        public List<EnCokSatanUrunlerDto> EnCokSatanUrunleriGetir()
        {
            return _uow.UrunDal.Select(null, c => new EnCokSatanUrunlerDto
            {
                UrunAdi = c.Adi,
                AdetToplam = c.UrunHareketleri.Where(f => f.UrunHareketTip == Entities.Enums.UrunHareketTip.Satis).Sum(f =>(decimal?) f.Miktar)??0
            }, c => c.UrunHareketleri).OrderBy(c=>c.AdetToplam).Take(10).ToList();
        }

        public IEnumerable<UrunHareket> UrunHareketListesiGetir(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            return _uow.UrunHareketDal.GetList(c => DbFunctions.TruncateTime(c.EklenmeTarihi) >= baslangicTarihi.Date && DbFunctions.TruncateTime(c.EklenmeTarihi) <= bitisTarihi.Date, c => c.Porsiyon, c => c.Urun,c=>c.Porsiyon.Birim);
        }
    }
}
