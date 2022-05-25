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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=.\\SQLEXPRESS;Database=kullanicikaydi;User Id=sa;Password=ilke001; ");
        }
        public DbSet<User> users { get; set; }
        public DbSet<Manager> managers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new ManagerConfig());
        }
    }
}
