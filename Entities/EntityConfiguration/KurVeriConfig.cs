using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfiguration
{
    public class KurVeriConfig : IEntityTypeConfiguration<KurVeri>
    {
        public void Configure(EntityTypeBuilder<KurVeri> builder)
        {
            builder.HasKey(a => a.KurId);
        }
    }
}
