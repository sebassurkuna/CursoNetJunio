using Curso.Biblioteca.Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.ServicioDefinicion
{
    public interface ILibroServicio
    {

        /// <summary>
        /// Este metodo obtener todos los libros de manera asincrona.
        /// </summary>
        Task<ICollection<LibroDto>> GetAllAsync();

        /// <summary>
        /// Este metodo obtener libro por id de manera asincrona.
        /// </summary>
        Task<LibroDto> GetByIdAsync(int id);

        /// <summary>
        /// Este metodo crear libro de manera asincrona.
        /// </summary>
        Task<bool> CreateAsync(CrearLibroDto libro);

        /// <summary>
        /// Este metodo actualizar libro de manera asincrona.
        /// </summary>
        Task<bool> UpdateAsync(int id, CrearLibroDto libroDto);

        /// <summary>
        /// Este metodo eliminar libro de manera asincrona.
        /// </summary>
        Task<bool> DeleteAsync(int id);

    }
}
