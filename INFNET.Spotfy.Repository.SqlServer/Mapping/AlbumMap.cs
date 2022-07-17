using INFNET.Spotfy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Repository.SqlServer.Mapping
{
    public class AlbumMap : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.Nome).IsRequired();
            builder.OwnsOne(x => x.Banda, a =>
              {
                  a.Property(c => c.Nome).HasColumnName("Banda");
              });
            builder.HasMany(x=>x.Musicas).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
