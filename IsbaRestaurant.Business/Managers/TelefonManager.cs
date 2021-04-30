using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class TelefonManager : BaseManager<Telefon>, ITelefonService
    {
        public TelefonManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
