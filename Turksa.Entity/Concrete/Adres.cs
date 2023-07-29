using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turksa.Entity.Abstract;

namespace Turksa.Entity.Concrete
{
    public enum AdresTipi : byte
    {
        Merkez = 1,
        Depo,
        Sube,
        Fabrika

    }
    public class Adres:BaseEntity
    {
        public AdresTipi? AdresTipi { get; set; }
        public string? Sehir { get; set; }
        public string? Ilce { get; set; }
        public string? CaddeSokak { get; set; }
        public int CariId { get; set; }
        public Cari? Cari { get; set; }
        public int? KisiId { get; set; }
        public Kisi? Kisi { get; set; }

    }
}
