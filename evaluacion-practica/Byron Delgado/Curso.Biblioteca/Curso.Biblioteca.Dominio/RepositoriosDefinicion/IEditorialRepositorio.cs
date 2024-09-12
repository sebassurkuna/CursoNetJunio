using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.Repositorios
{
    public interface IEditorialRepositorio
    {
        /// <summary>
        /// Este metodo permite obtener todas las editoriales.
        /// </summary>
        IQueryable<Editorial> GetAll();

        /// <summary>
        /// Este metodo permite crear una editorial.
        /// </summary>
        Task CreateAsync(Editorial editorial);

        /// <summary>
        /// Este metodo permite actualizar una editorial.
        /// </summary>
        Task UpdateAsync(Editorial editorial);

        /// <summary>
        /// Este metodo permite eliminar una editorial.
        /// </summary>
        Task DeleteAsync(Editorial editorial);
    }
}
