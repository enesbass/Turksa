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
    public class UrunAgaciConfig:BaseConfig<UrunAgaci>
    {
        public override void Configure(EntityTypeBuilder<UrunAgaci> builder)
        {
            base.Configure(builder);
        }
    }
}
