using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Infra.Data.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AGS.ERP.Infra.Data.Mappings
{
    public class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public override void Map(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(e => e.EnderecoId);

            builder.Property(e => e.EnderecoId)
                .IsRequired();

            builder.Property(e => e.Logradouro)
                .HasMaxLength(200)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(e => e.CEP)
                .HasMaxLength(10)
                .HasColumnType("varchar(10)");


            builder.Property(e => e.Complemento)
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Numero)
                .HasMaxLength(10)
                .HasColumnType("varchar(10)");

            builder.Property(e => e.Bairro)
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(e => e.UF)
                .HasMaxLength(2)
                .HasColumnType("Char(2)")
                .IsRequired();
               
                
        }
    }
}
