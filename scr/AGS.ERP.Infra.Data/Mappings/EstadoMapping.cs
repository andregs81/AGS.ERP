using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Infra.Data.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AGS.ERP.Infra.Data.Mappings
{
    public class EstadoMapping : EntityTypeConfiguration<Estado>
    {
        public override void Map(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estados");
            builder.HasKey(e => e.UF);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(e => e.UF)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnType("char(2)");

            builder.HasMany(e => e.Cidades)
                .WithOne(e => e.Estado)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
