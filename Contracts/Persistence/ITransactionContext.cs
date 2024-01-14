namespace Contracts.Persistence;

public interface ITransactionContext
{
    public Task MigrateAsync(CancellationToken cancellationToken = default);
}