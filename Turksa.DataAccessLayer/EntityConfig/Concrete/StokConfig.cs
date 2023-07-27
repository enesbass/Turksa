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
    public class StokConfig:BaseConfig<Stok>
    {
        public override void Configure(EntityTypeBuilder<Stok> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => p.StokKodu).IsUnique();
            builder.Property(p => p.StokKodu).HasMaxLength(100);
            builder.Property(p => p.StokAdi).HasMaxLength(100);

        }
    }
}
