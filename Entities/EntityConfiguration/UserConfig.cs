using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfiguration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {        
            
            builder.HasKey(a => a.UserId);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(30);
            builder.Property(a => a.Surname).IsRequired().HasMaxLength(50);
        }
    }
}
