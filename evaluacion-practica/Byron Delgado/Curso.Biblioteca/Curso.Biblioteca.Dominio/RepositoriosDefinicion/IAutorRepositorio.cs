using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.Repositorios
{
    public interface IAutorRepositorio
    {
        /// <summary>
        /// Este metodo permite obtener todos los autores.
        /// </summary>
        IQueryable<Autor> GetAll();

        /// <summary>
        /// Este metodo permite crear autor.
        /// </summary>
        Task CreateAsync(Autor autor);

        /// <summary>
        /// Este metodo permite actualizar autor.
        /// </summary>
        Task UpdateAsync(Autor autor);

        /// <summary>
        /// Este metodo permite eliminar autor.
        /// </summary>
        Task DeleteAsync(Autor autor);
    }
}
