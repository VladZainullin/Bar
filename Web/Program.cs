using Persistence;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services
    .AddPersistenceServices(builder.Configuration);

app.Run();