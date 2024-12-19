using Microsoft.EntityFrameworkCore;
using RangoWeb.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(
    o => o.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConStr"])
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/rangos/{numero}", (int numero) => {

    return "Está funcionando ok" + numero;
});

app.MapGet("/rangos", () => {

    return "Está funcionando ok";
});

app.Run();
