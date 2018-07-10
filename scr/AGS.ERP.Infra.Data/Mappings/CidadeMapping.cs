using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Infra.Data.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Infra.Data.Mappings
{
    public class CidadeMapping : EntityTypeConfiguration<Cidade>
    {
        public override void Map(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidades");
            builder.HasKey(c => c.CidadeId);

            builder.Property(c => c.CidadeId)
                .IsRequired();

            builder.Property(c => c.UF)
                .HasColumnType("Char(2)")
                .HasMaxLength(2)
                .IsRequired();

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar(150)");

            builder.HasOne(c => c.Estado)
                .WithMany(e => e.Cidades)
                .HasForeignKey("UF")
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
