using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Turksa.Entity.Concrete;

namespace Turksa.DataAccessLayer.Context
{
    public class SqlDbContext:DbContext
    {
        public DbSet<Birim> Birimler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Vergi> Vergiler { get; set; }
        public DbSet<UrunAgaci> UrunAgaclari { get; set; }
        public DbSet<Kisi> Kisiler { get; set; }

        public DbSet<Adres> Adresler { get; set; }
        public SqlDbContext()
        {

        }
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=TurksaDb;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
