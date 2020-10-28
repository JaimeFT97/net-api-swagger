using net_api_swagger.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Infrastructure.EntityConfiguration
{
    public class ArtistEntityConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> artistConfiguration)
        {
            artistConfiguration.HasKey(p => p.Id);
            artistConfiguration.Property(p => p.Artistic_name)
                .HasMaxLength(30)
                .IsRequired(true);
            artistConfiguration.Property(p => p.Real_name)
                .HasMaxLength(30)
                .IsRequired(true);
            artistConfiguration.Property<int>("Country_id")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Country_id")
                .IsRequired(true);
            artistConfiguration.HasOne(p => p.Country)
                .WithMany()
                .HasForeignKey("Country_id");
            artistConfiguration.Property(p => p.Average_salary)
                .IsRequired(true);
            artistConfiguration.Property(p => p.Occupation)
                .HasMaxLength(30)
                .IsRequired(true);
        }
    }
}
