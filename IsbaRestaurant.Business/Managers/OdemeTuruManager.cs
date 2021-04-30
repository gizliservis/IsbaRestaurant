using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;

namespace IsbaRestaurant.Business.Managers
{
    public class OdemeTuruManager : BaseManager<OdemeTuru>, IOdemeTuruService
    {
        public OdemeTuruManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
