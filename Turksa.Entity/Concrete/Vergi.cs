using Turksa.Entity.Abstract;

namespace Turksa.Entity.Concrete
{
    public class Vergi: BaseEntity
    {
        public string VergiAdi { get; set; }
        public decimal Oran { get; set; }

    }
}