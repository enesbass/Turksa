using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turksa.Entity.Abstract;

namespace Turksa.Entity.Concrete
{
    public class UrunAgaci:BaseEntity
    {
        public int StokId { get; set; }
        public Stok Stok { get; set; }
        public double Adet { get; set; }
    }
}
