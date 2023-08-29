using System.Reflection.Emit;
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace infrastructure.Data;

public class BodegaContext : DbContext
{
    public BodegaContext(DbContextOptions<BodegaContext> options)  : base(options){

    }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TipoProducto> TipoProductos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            modelBuilder.Entity<TipoProducto>() 
            .HasMany<Producto>(g => g.Productos) 
            .WithOne(s => s.TipoProducto) 
            .HasForeignKey(s => s.IdTipoProductoFk);

        }

}
