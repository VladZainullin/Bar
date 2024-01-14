using Application;
using Persistence;
using Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddPersistenceServices(builder.Configuration)
    .AddApplicationServices()
    .AddWebServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();