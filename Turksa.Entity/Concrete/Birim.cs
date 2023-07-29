using Turksa.Entity.Abstract;

namespace Turksa.Entity.Concrete
{
    public class Birim:BaseEntity
    {

        public string BirimAdi { get; set; }
        public ICollection<Stok> Stoklar { get; set; }

    }
}