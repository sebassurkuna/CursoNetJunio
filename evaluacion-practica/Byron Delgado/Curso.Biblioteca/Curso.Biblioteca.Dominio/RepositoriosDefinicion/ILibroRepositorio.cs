using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.Repositorios
{
    public interface ILibroRepositorio
    {
        /// <summary>
        /// Este metodo permite obtener libros.
        /// </summary>
        IQueryable<Libro> GetAll();

        /// <summary>
        /// Este metodo crear libro.
        /// </summary>
        Task CreateAsync(Libro libro);

        /// <summary>
        /// Este metodo actualizar libro.
        /// </summary>
        Task UpdateAsync(Libro libro);

        /// <summary>
        /// Este metodo eliminar libro.
        /// </summary>
        Task DeleteAsync(Libro libro);
    }
}
