using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.DataAccess.Mappings
{
   public class EkMalzemeMap:EntityTypeConfiguration<EkMalzeme>
    {
        public EkMalzemeMap()
        {
            Property(c => c.EkmalzemeAdi).HasMaxLength(50);
            Property(c => c.Fiyat).HasPrecision(10, 2);

            ToTable("EkMalzemeler");

            Property(c => c.EkmalzemeAdi).HasColumnName("EkMalzemeAdi");
            Property(c => c.Fiyat).HasColumnName("Fiyat");
            Property(c => c.UrunId).HasColumnName("UrunId");
        }
    }
}
