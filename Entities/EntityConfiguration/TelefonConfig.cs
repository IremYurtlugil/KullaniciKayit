using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfiguration
{
    public class TelefonConfig : IEntityTypeConfiguration<Telefon>
    {
        public void Configure(EntityTypeBuilder<Telefon> builder)
        {
            builder.HasKey(a => a.TelefonId);
            builder.Property(a => a.TelefonNo).IsRequired();
        }
    }
}
