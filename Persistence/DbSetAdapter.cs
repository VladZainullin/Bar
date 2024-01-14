using System.Collections;
using System.Linq.Expressions;
using Contracts.Persistence;

namespace Persistence;

internal class DbSetAdapter<TEntity> : IDbSet<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;

    public DbSetAdapter(AppDbContext context)
    {
        _context = context;
    }

    public virtual Type ElementType => ((IQueryable<TEntity>)_context.Set<TEntity>()).ElementType;

    public virtual Expression Expression => ((IQueryable<TEntity>)_context.Set<TEntity>()).Expression;

    public virtual IQueryProvider Provider => ((IQueryable<TEntity>)_context.Set<TEntity>()).Provider;

    public virtual IEnumerator<TEntity> GetEnumerator()
    {
        return ((IEnumerable<TEntity>)_context.Set<TEntity>()).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<TEntity>)_context.Set<TEntity>()).GetEnumerator();
    }
}