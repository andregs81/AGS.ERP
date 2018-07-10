using AGS.ERP.Domain.Entities;
using AGS.ERP.Infra.Data.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Infra.Data.Mappings
{
    class FornecedorMapping : EntityTypeConfiguration<Fornecedor>
    {
        public override void Map(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedores");
            builder.HasKey(f => f.FornecedorId);

            builder.Property(f => f.Nome)
                .HasMaxLength(150)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(f => f.CNPJ)
                .HasMaxLength(14)
                .HasColumnType("varchar(14)");

            builder.Property(f => f.CPF)
                .HasMaxLength(11)
                .HasColumnType("varchar(11)");


        }
    }
}
