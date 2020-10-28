using net_api_swagger.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Infrastructure.EntityConfiguration
{
    public class SongEntityConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> SongConfiguration)
        {
            SongConfiguration.HasKey(s => s.Id);
            SongConfiguration.Property(s => s.Song_name)
                .HasMaxLength(30)
                .IsRequired();
            SongConfiguration.Property(s => s.Duration)
                .HasMaxLength(30)
                .IsRequired();

            SongConfiguration.Property<int>("Gender_id")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Gender_id")
               .IsRequired(true);
            SongConfiguration.HasOne(s => s.Gender)
                .WithMany()
                .HasForeignKey("Gender_id");

            SongConfiguration.Property<int>("Language_id")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Language_id")
               .IsRequired(true);
            SongConfiguration.HasOne(s => s.Language)
                .WithMany()
                .HasForeignKey("Language_id");

            SongConfiguration.Property<int>("Country_id")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Country_id")
               .IsRequired(true);
            SongConfiguration.HasOne(s => s.Country)
                .WithMany()
                .HasForeignKey("Country_id");

            SongConfiguration.Property(s => s.Link_song)
                .HasMaxLength(150)
                .IsRequired();

            SongConfiguration.Property<int>("Album_id")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Album_id")
               .IsRequired(true);
            SongConfiguration.HasOne(s => s.Album)
                .WithMany()
                .HasForeignKey("Album_id");

            SongConfiguration.Property<int>("Artist_id")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Artist_id")
               .IsRequired(true);
            SongConfiguration.HasOne(s => s.Artist)
                .WithMany()
                .HasForeignKey("Artist_id");
        }
    }
}
