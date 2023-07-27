using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Turksa.Entity.Abstract;

namespace Turksa.Entity.Concrete
{
    public class Kategori:BaseEntity
    {
        public string KategoriAdi { get; set; }
        public int? UstKategoriId { get; set; }
        public Kategori? UstKategori { get; set; }
        public ICollection<Kategori>? AltKategoriler { get; set; }
    }
}
