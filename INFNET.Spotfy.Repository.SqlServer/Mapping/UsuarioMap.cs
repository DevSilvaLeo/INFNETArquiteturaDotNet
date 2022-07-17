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
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Foto).IsRequired().HasMaxLength(500);
            builder.Property(x => x.DataNascimento).IsRequired();
            builder.OwnsOne(x => x.CPF, c =>
            {
                c.Property(d => d.Value).HasColumnName("CPF");
            });
            builder.OwnsOne(x => x.Email, v =>
            {
                v.Property(e => e.Value).HasColumnName("Email");
            });
            builder.OwnsOne(x => x.Senha, s =>
            {
                s.Property(p => p.Value).HasColumnName("Senha");
            });
        }
    }
}
