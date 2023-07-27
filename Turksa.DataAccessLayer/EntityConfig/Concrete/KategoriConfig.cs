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
    public class KategoriConfig:BaseConfig<Kategori>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KategoriAdi).HasMaxLength(50);
        }
    }
}
