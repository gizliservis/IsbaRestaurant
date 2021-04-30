using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class GarsonManager : BaseManager<Garson>, IGarsonService
    {
        public GarsonManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
