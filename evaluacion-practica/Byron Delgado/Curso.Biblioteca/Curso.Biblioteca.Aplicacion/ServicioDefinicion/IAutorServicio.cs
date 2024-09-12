using Curso.Biblioteca.Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.ServicioDefinicion
{
    public interface IAutorServicio
    {
        /// <summary>
        /// Este metodo obtener todos los autores de manera asincrona.
        /// </summary>
        Task<ICollection<AutorDto>> GetAllAsync();

        /// <summary>
        /// Este metodo obtener autor por id de manera asincrona.
        /// </summary>
        Task<AutorDto> GetByIdAsync(int id);

        /// <summary>
        /// Este metodo crear autor de manera asincrona.
        /// </summary>
        Task<bool> CreateAsync(CrearAutorDto autor);

        /// <summary>
        /// Este metodo actualizar autor de manera asincrona.
        /// </summary>
        Task<bool> UpdateAsync(int id, CrearAutorDto autorDto);

        /// <summary>
        /// Este metodo eliminar autor de manera asincrona.
        /// </summary>
        Task<bool> DeleteAsync(int id);
    }
}
