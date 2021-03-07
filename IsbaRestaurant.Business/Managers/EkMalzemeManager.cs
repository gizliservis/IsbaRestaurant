using IsbaRestaurant.Business.Managers.Base;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Business.Managers
{
    public class EkMalzemeManager:BaseManager<EkMalzeme>,IEkMalzemeService
    {

        public EkMalzemeManager(IUnitOfWork uow) : base(uow)
        {

        }
    }
}
