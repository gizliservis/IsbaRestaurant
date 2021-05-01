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
    public class AdisyonManager : BaseManager<Adisyon>, IAdisyonService
    {
        RestaurantUnitOfWork _uow;
        public AdisyonManager(IUnitOfWork uow) : base(uow)
        {
            _uow = (RestaurantUnitOfWork)uow;
        }

        public AdisyonToplamDto AdisyonToplamGetir()
        {
            return _uow.AdisyonDal.BindingList().Select(c => new AdisyonToplamDto
            {
                ToplamTutar =  c.UrunHareketleri.Where(f => f.UrunHareketTip == Entities.Enums.UrunHareketTip.Satis).Sum(f => f.ToplamTutar),
                IndirimTutar = c.UrunHareketleri.Where(f => f.UrunHareketTip == Entities.Enums.UrunHareketTip.Satis).Sum(f => f.ToplamTutar / 100 * f.Indirim),
                OdenenTutar = c.OdemeHareketleri == null ? 0 : c.OdemeHareketleri.Sum(f => f.Tutar)

            }).FirstOrDefault();
        }
        public List<AdisyonHareketDto> AdisyonHareketGetir(DateTime Tarih1,DateTime tarih2)
        {
            return _uow.AdisyonDal.Select(c => DbFunctions.TruncateTime(c.EklenmeTarihi) >= Tarih1.Date && DbFunctions.TruncateTime(c.EklenmeTarihi)<=tarih2.Date, c => new AdisyonHareketDto
            {
                AdisyonId=c.Id,
                AdisyonDurum = c.AdisyonDurum,
                Tutar = c.Tutar,
                Indirim = c.Indirim,
                GarsonAdi = c.Garson.Adi + " " + c.Garson.Soyadi,
                MasaAdi = c.Masa.Adi,
                MusteriAdi = c.Musteri.Adi + " " + c.Musteri.Soyadi,
                Tarih=c.EklenmeTarihi
            }, c => c.Masa, c => c.Garson, c => c.Musteri).ToList();
        }
    }
}
