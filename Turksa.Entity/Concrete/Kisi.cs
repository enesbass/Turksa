using Turksa.Entity.Abstract;

namespace Turksa.Entity.Concrete
{
    public class Kisi: BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool? Cinsiyet { get; set; }
        public string? Gsm { get; set; }

        public ICollection<Adres>? Adresler { get; set; }
    }
}