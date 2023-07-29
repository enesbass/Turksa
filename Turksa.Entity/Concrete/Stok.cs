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
        public int BirimId { get; set; }
        public Birim? Birim { get; set; }       

        public ICollection<Kategori>? Kategoriler { get; set; }         
         
        public decimal? Fiyat { get; set; }

        public decimal? Adet { get; set; }
        public int VergiId { get; set; }

        public Vergi? VergiOrani { get; set; }

        public StokTipi Stoktipi { get; set; }


        public Stok? UstUrun { get; set; }   
        public ICollection<Stok>? AltUrunler { get; set; }
        public ICollection<UrunAgaci>? UrunAgaci { get; set; }
        public Stok()
        {
            Kategoriler =new HashSet<Kategori>();
            UrunAgaci =new HashSet<UrunAgaci>();
        }

    }
}
