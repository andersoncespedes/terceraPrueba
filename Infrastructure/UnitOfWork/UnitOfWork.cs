using Core.Entities;
using Core.Interfaces;
using infrastructure.Data;
using Infrastructure.Data.Configuration;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly BodegaContext _context;
        private ProductoRepository _productos;
        private TipoProductoRepository _tipoProductos;
        public UnitOfWork(BodegaContext context){
            _context = context;
        }
        public IProductoInterface Productos {
            get{
                if(_productos == null){
                    _productos = new ProductoRepository(_context);
                }
                return _productos;
            }
        }
        public ITipoProductoInterface TipoProductos{
            get{
                if(_tipoProductos == null){
                    _tipoProductos = new TipoProductoRepository(_context);
                }
                return _tipoProductos;
            }
        }

    public void Dispose()
    {
        _context.Dispose();
    }
    public int Save(){
        throw new NotImplementedException();
    }
}
