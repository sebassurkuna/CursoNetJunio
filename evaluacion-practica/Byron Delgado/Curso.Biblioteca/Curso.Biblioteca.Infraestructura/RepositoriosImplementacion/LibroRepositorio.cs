using Curso.Biblioteca.Dominio.Entidades;
using Curso.Biblioteca.Dominio.Repositorios;
using Curso.Biblioteca.Infraestructura.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Infraestructura.RepositoriosImplementacion
{
    public class LibroRepositorio : ILibroRepositorio
    {
        private readonly BibliotecaDbContext _context;

        public LibroRepositorio(BibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Libro libro)
        {
            await _context.AddAsync(libro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Libro libro)
        {
            _context.Remove(libro);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Libro> GetAll()
        {
            return _context.Libros.AsQueryable();
        }

        public async Task UpdateAsync(Libro libro)
        {
            _context.Update(libro);
            await _context.SaveChangesAsync();
        }
    }
}
