using Application;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddPersistenceServices(builder.Configuration)
    .AddApplicationServices();

var app = builder.Build();

app.Run();