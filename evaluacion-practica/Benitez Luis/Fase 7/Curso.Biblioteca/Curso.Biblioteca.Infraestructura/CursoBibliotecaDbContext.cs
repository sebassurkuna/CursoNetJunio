using Curso.Biblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Infraestructura
{
    public class CursoBibliotecaDbContext : DbContext
    {
        public CursoBibliotecaDbContext(DbContextOptions<CursoBibliotecaDbContext> options) : base(options)
        {
        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder constructor)
        {
            var cadenaConexion = @"Server=(localdb)\mssqllocaldb; DataBase=PruebaPractica;Trusted_Connection=True";
            constructor.UseSqlServer(cadenaConexion);
        }
    }
}
