using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Dtos;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                ToplamTutar =c.UrunHareketleri==null ? 0 : c.UrunHareketleri.Where(f => f.UrunHareketTip == Entities.Enums.UrunHareketTip.Satis).Sum(f => f.ToplamTutar),
                IndirimTutar =c.UrunHareketleri.Where(f => f.UrunHareketTip == Entities.Enums.UrunHareketTip.Satis).Sum(f => f.ToplamTutar / 100 * f.Indirim),
                OdenenTutar=c.OdemeHareketleri==null?0:c.OdemeHareketleri.Sum(f=>f.Tutar)

            }).FirstOrDefault();
        }
    }
}
