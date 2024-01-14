namespace Contracts.Persistence;

public interface IDbSet<TEntity> : IQueryable<TEntity>
{
}