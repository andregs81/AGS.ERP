using AGS.ERP.Domain.Entities;
using AGS.ERP.Infra.Data.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AGS.ERP.Infra.Data.Mappings
{
    public class UnidadeMedidaMapping : EntityTypeConfiguration<UnidadeMedida>
    {
        public override void Map(EntityTypeBuilder<UnidadeMedida> builder)
        {
            builder.ToTable("Unidade_Medida");
            builder.HasKey(u => u.UnidadeMedidaId);


            builder.Property(u => u.UnidadeMedidaId)
                .HasMaxLength(3)
                .HasColumnType("varchar(3)")
                .IsRequired();

            builder.Property(u => u.Nome)
                .HasMaxLength(50)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
