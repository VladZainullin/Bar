using Contracts.Persistence;
using Domain.Entities;

namespace Persistence;

internal sealed class AppDbContextAdapter : IAppDbContext
{
    public AppDbContextAdapter(IDbSet<Cocktail> cocktails)
    {
        Cocktails = cocktails;
    }

    public IDbSet<Cocktail> Cocktails { get; }
}