using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class MusteriManager : BaseManager<Musteri>, IMusteriService
    {
        public MusteriManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
