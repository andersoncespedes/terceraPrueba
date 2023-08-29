using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class ProductoRepository : BaseRepository<Producto>, IProductoInterface
{
    public readonly BodegaContext _context;
    public ProductoRepository(BodegaContext context) : base(context){
        _context = context;
    }   
    public override async Task<IEnumerable<Producto>> GetAllAsync(){
        return await _context.Set<Producto>().ToListAsync();
    }     
    public override async Task<Producto> GetByIdAsync(int id){
        return await _context.Set<Producto>().FindAsync(id);
    }
}
