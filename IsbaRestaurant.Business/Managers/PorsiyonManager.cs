using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class PorsiyonManager : BaseManager<Porsiyon>, IPorsiyonService
    {

        public PorsiyonManager(IUnitOfWork uow) : base(uow)
        {

        }
    }
}
