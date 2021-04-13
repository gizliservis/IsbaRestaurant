using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.DataAccess.Mappings
{
   public class EkMalzemeHareketMap: EntityTypeConfiguration<EkMalzemeHareket>
    {
        public EkMalzemeHareketMap()
        {
            Property(c => c.Fiyat).HasPrecision(10, 2);

            ToTable("EkMalzemeHareketler");
            Property(c => c.Fiyat).HasColumnName("Fiyat");
            Property(c => c.EkMalzemeId).HasColumnName("EkMalzemeId");
            Property(c => c.UrunHareketId).HasColumnName("UrunHareketId");
        }
    }
}
