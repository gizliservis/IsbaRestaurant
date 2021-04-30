using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class AdresManager : BaseManager<Adres>, IAdresService
    {
        public AdresManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
