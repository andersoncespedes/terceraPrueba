
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.Configuration;

public class TipoProductoConfiguration : IEntityTypeConfiguration<TipoProducto>
{
    public void Configure(EntityTypeBuilder<TipoProducto> builder){
        builder.ToTable("tipo_producto");
        builder.Property(e => e.Despcripcion)
        .IsRequired()
        .HasMaxLength(20);
    }

}
