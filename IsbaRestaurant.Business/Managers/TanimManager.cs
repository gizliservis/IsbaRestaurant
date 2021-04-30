using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class TanimManager : BaseManager<Tanim>, ITanimService
    {
        public TanimManager(IUnitOfWork uow) : base(uow)
        {

        }
    }
}
