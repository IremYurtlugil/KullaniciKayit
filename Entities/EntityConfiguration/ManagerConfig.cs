using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfiguration
{
    public class ManagerConfig : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasKey(a => a.ManagerId);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(30);
            builder.Property(a => a.Surname).IsRequired().HasMaxLength(50);
            builder.HasData(new Manager { ManagerId = 1, Name = "Manager", Surname = "Mamager", Email = "manager@manager.com", Password = "manager" });
        }
    }
}
