using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class EkMalzemeManager : BaseManager<EkMalzeme>, IEkMalzemeService
    {

        public EkMalzemeManager(IUnitOfWork uow) : base(uow)
        {

        }
    }
}
