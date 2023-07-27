using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turksa.Entity.Abstract;

namespace Turksa.Entity.Concrete
{
    public enum StokTipi : byte
    {
        Hammadde = 1,
        YariMamul,
        Mamul
    }
    public class Stok:BaseEntity
    {
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }

        public Birim? Birim { get; set; }       //Anlamadık

        public ICollection<Kategori>? Kategoriler { get; set; }         //Anlamadık
         
        public decimal? Fiyat { get; set; }

        public decimal? Adet { get; set; }

        public Vergi? VergiOrani { get; set; }

        public StokTipi Stoktipi { get; set; }


        public Stok? UstUrun { get; set; }   //Anlamadık
        public ICollection<Stok>? AltUrunler { get; set; }

    }
}
