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
    public class MusicaMap : IEntityTypeConfiguration<Musica>
    {
        public void Configure(EntityTypeBuilder<Musica> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.OwnsOne(x => x.Duracao, d =>
              {
                  d.Property(m => m.Value).HasColumnName("Duracao");
              });
        }
    }
}
