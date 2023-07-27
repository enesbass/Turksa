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
    public class BirimConfig:BaseConfig<Birim>
    {
        public override void Configure(EntityTypeBuilder<Birim> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.BirimAdi).HasMaxLength(50);
        }
    }
}
