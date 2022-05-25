using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfiguration
{
    public class KullaniciConfig : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(a => a.KullanciId);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(30);
            builder.Property(a => a.Surname).IsRequired().HasMaxLength(50);
            
        }
    }
}
