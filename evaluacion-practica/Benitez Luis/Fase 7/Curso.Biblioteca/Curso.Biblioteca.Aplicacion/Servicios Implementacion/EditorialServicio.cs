using Curso.Biblioteca.Aplicacion.Dto;
using Curso.Biblioteca.Aplicacion.Servicios_Definicion;
using Curso.Biblioteca.Dominio.Entidades;
using Curso.Biblioteca.Dominio.IRepositoriosDefinicion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.Servicios_Implementacion
{
    public class EditorialServicio : IEditorialServicio
    {
        protected readonly IEditorialRepositorio editorialRepositorio;

        public EditorialServicio(IEditorialRepositorio editorialRepositorio)
        {
            this.editorialRepositorio = editorialRepositorio;
        }

        public async Task<bool> CreateAsync(CrearEditorialDto editorialDto)
        {
            var editorial = new Editorial
            {
                Nombre = editorialDto.Nombre,
                Direccion = editorialDto.Direccion
            };
            await editorialRepositorio.CreateAsync(editorial);

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var consulta = editorialRepositorio.GetAll();
            consulta = consulta.Where(c => c.Id == id);
            var editorial = consulta.SingleOrDefault();

            await editorialRepositorio.DeleteAsync(editorial);
            return true;
        }

        public async Task<ICollection<EditorialDto>> GetAllAsync()
        {
            var consulta = editorialRepositorio.GetAll();
            var listaEditoriales = await consulta.Select(x => new EditorialDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Direccion = x.Direccion
            }).ToListAsync();

            return listaEditoriales;
        }

        public async Task<EditorialDto> GetByIdAsync(int id)
        {
            var consulta = editorialRepositorio.GetAll();
            consulta = consulta.Where(c => c.Id == id);
            var editorial = await consulta.Select(x => new EditorialDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Direccion = x.Direccion
            }).SingleOrDefaultAsync();

            return editorial;
        }

        public async Task<bool> UpdateAsync(int id, CrearEditorialDto editorialDto)
        {
            var consulta = editorialRepositorio.GetAll();
            consulta = consulta.Where(c => c.Id == id);
            var editorial = consulta.SingleOrDefault();

            editorial.Nombre = editorialDto.Nombre;
            editorial.Direccion = editorialDto.Direccion;

            await editorialRepositorio.UpdateAsync(editorial);
            return true;
        }
    }
}
