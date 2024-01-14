using Domain.Entities;

namespace Contracts.Persistence;

public interface IAppDbContext
{
    IDbSet<Cocktail> Cocktails { get; }
}