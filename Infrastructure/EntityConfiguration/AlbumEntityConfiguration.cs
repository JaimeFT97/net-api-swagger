using net_api_swagger.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Infrastructure.EntityConfiguration
{
    public class AlbumEntityConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> albumConfiguration)
        {
            albumConfiguration.HasKey(a => a.Id);
            albumConfiguration.Property(a => a.Album_name)
                .HasMaxLength(30)
                .IsRequired();
            albumConfiguration.Property(a => a.Album_cover)
                .HasMaxLength(150)
                .IsRequired();
            albumConfiguration.Property(a => a.Song_quantity)
                .IsRequired();
            albumConfiguration.Property(a => a.Duration)
                .HasMaxLength(30)
                .IsRequired();
            albumConfiguration.Property(a => a.Link_album)
                .HasMaxLength(150)
                .IsRequired();
            albumConfiguration.Property<int>("Artist_id")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Artist_id")
               .IsRequired(true);
            albumConfiguration.HasOne(p => p.Artist)
                .WithMany()
                .HasForeignKey("Artist_id");
        }
    }
}
