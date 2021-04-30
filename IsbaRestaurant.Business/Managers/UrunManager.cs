using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class UrunManager : BaseManager<Urun>, IUrunService
    {
        public UrunManager(IUnitOfWork uow) : base(uow)
        {

        }

    }
}
