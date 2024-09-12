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
    public class EditorialRepositorio : IEditorialRepositorio
    {
        private readonly BibliotecaDbContext _context;

        public EditorialRepositorio(BibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Editorial editorial)
        {
            await _context.AddAsync(editorial);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Editorial editorial)
        {
            _context.Remove(editorial);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Editorial> GetAll()
        {
            return _context.Editoriales.AsQueryable();
        }

        public async Task UpdateAsync(Editorial editorial)
        {
            _context.Update(editorial);
            await _context.SaveChangesAsync();
        }
    }
}
