using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class EkMalzemeHareketManager : BaseManager<EkMalzemeHareket>, IEkMalzemeHareketService
    {
        public EkMalzemeHareketManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
