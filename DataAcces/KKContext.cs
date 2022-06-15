using Entities.Concrete;
using Entities.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces
{
    
    public class KKContext : DbContext
    {
        public KKContext(DbContextOptions<KKContext> options) : base(options)
        {

        }

        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Cari> Cari { get; set; }
        public DbSet<Telefon> Telefon { get; set; }
        public DbSet<Adres> Adres { get; set; }
        public DbSet<KurVeri> KurVeris { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);           
            modelBuilder.ApplyConfiguration(new KullaniciConfig());
            modelBuilder.ApplyConfiguration(new CariConfig());
            modelBuilder.ApplyConfiguration(new TelefonConfig());
            modelBuilder.ApplyConfiguration(new AdresConfig());
            modelBuilder.ApplyConfiguration(new KurVeriConfig());

        }
    }
}
