using Curso.Biblioteca.Aplicacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.Servicios_Definicion
{
    public interface ILibroServicio
    {
        Task<ICollection<LibroDto>> GetAllAsync();
        Task<LibroDto> GetByIdAsync(int id);
        Task<bool> CreateAsync(CrearLibroDto libro);

        Task<bool> UpdateAsync(int id, CrearLibroDto libroDto);
        Task<bool> DeleteAsync(int id);
    }
}
