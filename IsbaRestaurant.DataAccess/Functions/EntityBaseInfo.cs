using IsbaRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.DataAccess.Functions
{
   public static class EntityBaseInfo
    {
        public static void Add(DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries())
            {
                EntityBase changingEntity = (EntityBase)entry.Entity;
                switch (entry.State)
                {
                    case EntityState.Added:
                        if (changingEntity.Id==Guid.Empty)
                        {
                            changingEntity.Id = Guid.NewGuid();
                        }
                        changingEntity.EklenmeTarihi = DateTime.Now;
                        changingEntity.Ekleyen = "İsmail Cem Babaoğlu";
                        break;
                    case EntityState.Modified:
                        changingEntity.DuzenlenmeTarihi = DateTime.Now;
                        changingEntity.Duzenleyen = "İsmail Cem Babaoğlu";
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
