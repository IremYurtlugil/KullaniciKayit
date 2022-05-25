using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfiguration
{
    public class CariConfig : IEntityTypeConfiguration<Cari>
    {
        public void Configure(EntityTypeBuilder<Cari> builder)
        {
            builder.HasKey(a => a.CariId);
            builder.Property(a => a.Unvan).IsRequired();            
        }
    }
}
