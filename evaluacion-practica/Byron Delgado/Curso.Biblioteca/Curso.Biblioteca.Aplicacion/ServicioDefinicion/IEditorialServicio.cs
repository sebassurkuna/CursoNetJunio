using Curso.Biblioteca.Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.ServicioDefinicion
{
    public interface IEditorialServicio
    {
        /// <summary>
        /// Este metodo obtener todas las editoriales de manera asincrona.
        /// </summary>
        Task<ICollection<EditorialDto>> GetAllAsync();

        /// <summary>
        /// Este metodo obtener editorial por id de manera asincrona.
        /// </summary>
        Task<EditorialDto> GetByIdAsync(int id);

        /// <summary>
        /// Este metodo crear editorial de manera asincrona.
        /// </summary>
        Task<bool> CreateAsync(CrearEditorialDto editorial);

        /// <summary>
        /// Este metodo actualizar editorial de manera asincrona.
        /// </summary>
        Task<bool> UpdateAsync(int id, CrearEditorialDto editorialDto);

        /// <summary>
        /// Este metodo eliminar editorial de manera asincrona.
        /// </summary>
        Task<bool> DeleteAsync(int id);
    }
}
