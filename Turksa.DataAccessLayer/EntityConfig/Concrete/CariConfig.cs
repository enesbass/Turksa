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
    public class CariConfig:BaseConfig<Cari>
    {
        public override void Configure(EntityTypeBuilder<Cari> builder)
        {
            base.Configure(builder);
            builder.HasMany(p => p.Adresler).WithOne(a => a.Cari);
        }
    }
}
