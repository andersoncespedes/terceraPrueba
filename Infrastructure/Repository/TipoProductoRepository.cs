
using Core.Entities;
using Core.Interfaces;
using infrastructure.Data;

namespace Infrastructure.Repository;

    public class TipoProductoRepository : BaseRepository<TipoProducto>, ITipoProductoInterface
    {
        private readonly BodegaContext _context;
        public TipoProductoRepository(BodegaContext _context) : base(_context){
            _context = _context;
        }
    }
