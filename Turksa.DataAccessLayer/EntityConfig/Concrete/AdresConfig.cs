using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turksa.DataAccessLayer.EntityConfig.Abstract;
using Turksa.Entity.Concrete;

namespace Turksa.DataAccessLayer.EntityConfig.Concrete
{
    public class AdresConfig:BaseConfig<Adres>
    {
        public override void Configure(EntityTypeBuilder<Adres> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Sehir).HasMaxLength(50);
            builder.Property(p => p.Ilce).HasMaxLength(50);
            builder.Property(p => p.CaddeSokak).HasMaxLength(50);
            builder.HasOne(p => p.Cari).WithMany(c => c.Adresler);
        }
    }
}
