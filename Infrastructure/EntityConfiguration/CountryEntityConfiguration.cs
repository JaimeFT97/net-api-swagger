using net_api_swagger.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Infrastructure.EntityConfiguration
{
    public class CountryEntityConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> countryConfiguration)
        {
            countryConfiguration.HasKey(p => p.Id);
            countryConfiguration.Property(p => p.Country_name)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
