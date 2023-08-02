using Turksa.DataAccessLayer.Abstract;
using Turksa.DataAccessLayer.Concrete;
using Turksa.Entity.Concrete;
namespace Turksa.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StokRepository stokRepository = new StokRepository();
            //IStokRepository stokRepository1 = new StokRepository();
            IBirimRepository birimRepository = new BirimRepository();

            Birim birim = new Birim()
            {
                BirimAdi = "Litre"
            };
            Birim kg = new Birim() { BirimAdi = "Kg" };

            birimRepository.Insert(birim);
            birimRepository.Insert(kg);

            //Stok kalem = new Stok();
            //kalem.Stoktipi = StokTipi.Mamul;
            //kalem.StokAdi = "Kursun Kalem";
            //kalem.StokKodu = "K.Kalem.001";
            //kalem.Birim = new Birim() { BirimAdi = "Adet" };

            //StokRepository repository = new StokRepository();


            Console.WriteLine("Hello, World!");
        }
    }
}