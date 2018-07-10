using AGS.ERP.Domain.Entities;
using AGS.ERP.Infra.Data.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AGS.ERP.Infra.Data.Mappings
{
    class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public override void Map(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(c => c.ClienteId);

            builder.Property(c => c.ClienteId)
                .IsRequired();

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(c => c.CPF)
                .HasColumnType("varchar(11)")
                .HasMaxLength(11);

            builder.Property(c => c.CNPJ)
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.HasMany(c => c.Endereco);

            builder.Ignore(c => c.ResultadoValidacao);


        }
    }
}
