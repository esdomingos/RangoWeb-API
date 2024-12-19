using Microsoft.EntityFrameworkCore;
using RangoWeb.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(
    o => o.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConStr"])
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/rango/{id}", (RangoDbContext rangoDbContext, int id) => {

    return rangoDbContext.Rangos.FirstOrDefault(x => x.Id == id);
});

app.MapGet("/rangos", () => {

    return "Está funcionando ok";
});

app.Run();
