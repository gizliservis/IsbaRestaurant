using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace IsbaRestaurant.Business.Managers
{
    public class OdemeHareketManager : BaseManager<OdemeHareket>, IOdemeHareketService
    {
        RestaurantUnitOfWork _uow;
        public OdemeHareketManager(IUnitOfWork uow) : base(uow)
        {
            _uow = (RestaurantUnitOfWork)uow;
        }

        public IEnumerable<OdemeHareket> OdemeHareketListesiGetir(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            return _uow.OdemeHareketDal.GetList(c => DbFunctions.TruncateTime(c.EklenmeTarihi) >= baslangicTarihi && DbFunctions.TruncateTime(c.EklenmeTarihi) <= bitisTarihi, c => c.OdemeTuru, c => c.OdemeTuru.OdemeTur);
        }
    }
}
