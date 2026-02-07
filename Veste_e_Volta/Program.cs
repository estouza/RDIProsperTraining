using Microsoft.EntityFrameworkCore;
using VesteEVolta.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<PostgresContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=root"));

var app = builder.Build();

app.MapControllers();
app.Run();
