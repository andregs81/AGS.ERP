using AGS.ERP.Domain.Entities;
using AGS.ERP.Infra.Data.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AGS.ERP.Infra.Data.Mappings
{
    public class UnidadeMedidaProdutoMapping : EntityTypeConfiguration<UnidadeMedidaProduto>
    {
        public override void Map(EntityTypeBuilder<UnidadeMedidaProduto> builder)
        {
            builder.ToTable("Unidade_Medida_Produto");
            builder.HasKey(u => new { u.ProdutoId, u.UnidadeMedidaId, u.PesoFator });

            builder.Property(u => u.UnidadeMedidaId)
                .HasColumnType("varchar(3)")
                .HasMaxLength(3)
                .IsRequired();

            builder.Property(u => u.PesoFator)
                .HasDefaultValue(1)
                .IsRequired();


        }
    }
}
