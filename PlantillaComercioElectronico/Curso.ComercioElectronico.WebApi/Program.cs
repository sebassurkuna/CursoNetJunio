using Curso.ComercioElectronico.Aplicacion;
using Curso.ComercioElectronico.Aplicacion.Services;
using Curso.ComercioElectronico.Aplicacion.ServicesImpl;
using Curso.ComercioElectronico.Dominio;
using Curso.ComercioElectronico.Dominio.Repositories;
using Curso.ComercioElectronico.Infraestructura;
using Curso.ComercioElectronico.Infraestructura.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Agregar conexion a base de datos
builder.Services.AddDbContext<ComercioElectronicoDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ComercioElectronico"));
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt => {
    opt.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("*");
    });
});


//Asp.net (Es el tercer actor quien crea los objetos)
//Configurar las dependencias. Se lo realiza con IServiceCollection

//Forma. Generic
//Repositorios
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<ICatalogoRepositorio, CatalogoRepositorio>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IProductTypeRepository, ProductTypeRepository>();

//Forma. Metodos.
//Servicios de aplicacion
builder.Services.AddTransient(typeof(ICatalogoAplicacion), typeof(CatalogoAplicacion));
builder.Services.AddTransient<IProductAppService, ProductAppService>();
builder.Services.AddTransient<IBrandAppService, BrandAppService>();
builder.Services.AddTransient<IProductTypeAppService, ProductTypeAppService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
