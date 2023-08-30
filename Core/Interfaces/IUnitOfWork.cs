using Core.Entities;
namespace Core.Interfaces;
public interface IUnitOfWork
{
    IProductoInterface Productos { get; }
    ITipoProductoInterface TipoProductos { get; }
}
