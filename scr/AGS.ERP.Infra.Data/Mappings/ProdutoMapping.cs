using AGS.ERP.Domain.Entities;
using AGS.ERP.Infra.Data.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AGS.ERP.Infra.Data.Mappings
{
    public class ProdutoMapping : EntityTypeConfiguration<Produto>
    {
        public override void Map(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto")
                .HasKey("ProdutoId");

            builder.Property(p => p.ProdutoId)
                .IsRequired();

            builder.Property(p => p.Codigo)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("varchar(30)");

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar(150)");

            builder.HasMany(p => p.UnidadesMedida)
                .WithOne(u => u.Produto);

        }
    }
}
