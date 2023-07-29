using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turksa.Entity.Abstract;

namespace Turksa.Entity.Concrete
{
    public class Cari: BaseEntity
    {
        public string CariKod { get; set; }
        public string CariAdi { get; set; }
        public ICollection<Adres>? Adresler { get; set; }
        public ICollection<Kisi>? KontakKisiler { get; set; }

        public string? VergiDairesi { get; set; }
        public string? VergiNo { get; set; }
    }
}
