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
    public class ArtistaMap : IEntityTypeConfiguration<Artista>
    {
        public void Configure(EntityTypeBuilder<Artista> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.Nome).IsRequired();
            builder.HasMany(x=>x.Albuns).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
