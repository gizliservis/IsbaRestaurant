using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class MasaManager : BaseManager<Masa>, IMasaService
    {
        public MasaManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
