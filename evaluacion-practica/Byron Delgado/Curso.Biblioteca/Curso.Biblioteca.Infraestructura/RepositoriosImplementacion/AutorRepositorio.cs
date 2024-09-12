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
    public class AutorRepositorio : IAutorRepositorio
    {
        private readonly BibliotecaDbContext _context;

        public AutorRepositorio(BibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Autor autor)
        {
            await _context.AddAsync(autor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Autor autor)
        {
            _context.Remove(autor);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Autor> GetAll()
        {
            return _context.Autores.AsQueryable();
        }

        public async Task UpdateAsync(Autor autor)
        {
            _context.Update(autor);
            await _context.SaveChangesAsync();
        }
    }
}
