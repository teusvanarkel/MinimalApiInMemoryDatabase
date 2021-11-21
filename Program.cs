using Microsoft.EntityFrameworkCore;
using MinimalApiTest.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Database>(opt => opt.UseInMemoryDatabase("Persons"));

// build the builder
var app = builder.Build();




app.MapGet("/", () => "Hello World!");

app.MapGet("/persons", async (Database database) =>
    await database.Persons.ToListAsync());

app.Run();
