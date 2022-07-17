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
    public class PlaylistMap : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.DataCriacao).ValueGeneratedOnAdd();
            builder.HasOne(x => x.Musicas).WithMany();
            builder.HasOne(x=>x.Usuario).WithMany(u=>u.Playlists);
        }
    }
}
