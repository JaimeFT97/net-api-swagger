using net_api_swagger.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Infrastructure.EntityConfiguration
{
    public class GenderEntityConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> GenderConfiguration)
        {
            GenderConfiguration.HasKey(g => g.Id);
            GenderConfiguration.Property(g => g.Gender_name)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
