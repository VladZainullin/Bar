using Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Options;

namespace Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddDbContextPool<AppDbContext>(options =>
            {
                var connectionStringOptions = configuration
                    .GetRequiredSection(nameof(ConnectionStringOptions))
                    .Get<ConnectionStringOptions>();

                options
                    .UseSnakeCaseNamingConvention()
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll)
                    .UseNpgsql(connectionStringOptions!.Postgres);
            })
            .AddScoped<AppDbContext>()
            .AddScoped<IDbSet<Cocktail>, DbSetAdapter<Cocktail>>()
            .AddScoped<ITransactionContext, AppDbContextAdapter>()
            .AddScoped<IAppDbContext, AppDbContextAdapter>();

        return services;
    }
}