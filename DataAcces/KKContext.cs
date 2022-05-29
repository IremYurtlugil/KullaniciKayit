using Entities.Concrete;
using Entities.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces
{
    // DESKTOP-19RC398
    //Server=.\SQLEXPRESS;Database=kullanicikaydi;User Id=sa;Password=ilke001;"
    public class KKContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Server=(localdb)\\MsSqlLocalDb;Database=KullaniciKaydi;Trusted_Connection=True;");
        }
       
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Cari> Cari { get; set; }
        public DbSet<Telefon> Telefon { get; set; }
        public DbSet<Adres> Adres { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);           
            modelBuilder.ApplyConfiguration(new KullaniciConfig());
            modelBuilder.ApplyConfiguration(new CariConfig());
            modelBuilder.ApplyConfiguration(new TelefonConfig());
            modelBuilder.ApplyConfiguration(new AdresConfig());

        }
    }
}
