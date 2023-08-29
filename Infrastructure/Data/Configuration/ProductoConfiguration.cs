
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.Configuration;

    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder){
            builder.ToTable("producto");
            builder.Property(e => e.NombreProducto)
            .IsRequired()
            .HasMaxLength(20);
            builder.Property(e => e.CodeProducto)
            .IsRequired()
            .HasMaxLength(20);
            builder.HasIndex(e => e.CodeProducto)
            .IsUnique();
            builder.Property(e => e.Precio)
            .IsRequired()
            .HasColumnType("double");
        }
    }
