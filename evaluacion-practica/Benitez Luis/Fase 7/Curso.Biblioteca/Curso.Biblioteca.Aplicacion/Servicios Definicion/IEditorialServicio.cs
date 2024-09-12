using Curso.Biblioteca.Aplicacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.Servicios_Definicion
{
    public interface IEditorialServicio
    {
        Task<ICollection<EditorialDto>> GetAllAsync();
        Task<EditorialDto> GetByIdAsync(int id);
        Task<bool> CreateAsync(CrearEditorialDto editorial);
        Task<bool> UpdateAsync(int id, CrearEditorialDto editorialDto);
        Task<bool> DeleteAsync(int id);
    }
}
