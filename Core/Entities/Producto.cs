
namespace Core.Entities;

public class Producto : BaseEntity
{
    public string ? NombreProducto { get; set; }
    public string ? CodeProducto { get; set; }
    public double ? Precio { get; set; }
    public int ? Cantidad { get; set; }
    public int ? IdTipoProductoFk { get; set; }
    public TipoProducto ? TipoProducto { get; set; }
}
