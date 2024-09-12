using Curso.Biblioteca.Aplicacion.Servicios_Definicion;
using Curso.Biblioteca.Aplicacion.Servicios_Implementacion;
using Curso.Biblioteca.Dominio.IRepositoriosDefinicion;
using Curso.Biblioteca.Infraestructura;
using Curso.Biblioteca.Infraestructura.RepositoriosImplementacion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<CursoBibliotecaDbContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddTransient<IAutorRepositorio, AutorRepositorio>();
builder.Services.AddTransient<IEditorialRepositorio, EditorialRepositorio>();
builder.Services.AddTransient<IEditorialServicio, EditorialServicio>();
builder.Services.AddTransient<ILibroRepositorio, LibroRepositorio>();
builder.Services.AddTransient<ILibroServicio, LibroServicio>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
