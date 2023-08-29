using System.Collections;
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly BodegaContext _context;
    public BaseRepository(BodegaContext context){
        _context = context;
    }
    public virtual async Task<T> GetByIdAsync(int id){
        return await _context.Set<T>().FindAsync(id);
    }
    public virtual async Task<IEnumerable<T>> GetAllAsync(){
        return await _context.Set<T>().ToListAsync();
    }
    public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression){
        return  _context.Set<T>().Where(expression);
    }
    public virtual void Add(T entity){
        _context.Set<T>().Add(entity);
    }
    public virtual void AddRange(IEnumerable<T> entity){
        _context.Set<T>().AddRange(entity);
    }
    public virtual void Remove(T entity){
        _context.Set<T>().Remove(entity);
    }
    public virtual void RemoveRange(IEnumerable<T> entity){
        _context.Set<T>().RemoveRange(entity);
    }
    public virtual void Update(T entity){
        _context.Set<T>().Update(entity);
    }
}
