using Curso.Biblioteca.Aplicacion.Dto;
using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.Servicios_Definicion
{
    public interface IAutorServicio
    {
        Task<ICollection<AutorDto>> GetAllAsync();
        Task<AutorDto> GetByIdAsync(int id);
        Task<bool> CreateAsync(CrearAutorDto autor);
        Task<bool> UpdateAsync(int id, CrearAutorDto autorDto);
        Task<bool> DeleteAsync(int id);
    }
}
