using Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

internal sealed class AppDbContextAdapter : IAppDbContext, ITransactionContext
{
    private readonly AppDbContext _context;

    public AppDbContextAdapter(AppDbContext context, IDbSet<Cocktail> cocktails)
    {
        _context = context;
        Cocktails = cocktails;
    }

    public IDbSet<Cocktail> Cocktails { get; }
    public Task MigrateAsync(CancellationToken cancellationToken = default)
    {
        return _context.Database.MigrateAsync(cancellationToken);
    }
}