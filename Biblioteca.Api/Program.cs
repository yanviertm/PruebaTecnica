using Biblioteca.Core.Interfaces;
using Biblioteca.Infrastructure.Data;
using Biblioteca.Infrastructure.Servicios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --------------------
// Configuración de servicios
// --------------------
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddScoped<IAutorService, AutorService>();
builder.Services.AddScoped<ILibroService, LibroService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Biblioteca API v1");
    c.RoutePrefix = string.Empty; 
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
