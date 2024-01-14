using Application;
using Contracts.Persistence;
using Persistence;
using Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddPersistenceServices(builder.Configuration)
    .AddApplicationServices()
    .AddWebServices();

var app = builder.Build();

var factory = app.Services.GetRequiredService<IServiceScopeFactory>();

var scope = factory.CreateScope();

var transactionContext = scope.ServiceProvider.GetRequiredService<ITransactionContext>();

await transactionContext.MigrateAsync();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();