using Curso.Biblioteca.Aplicacion.Dtos;
using Curso.Biblioteca.Aplicacion.ServicioDefinicion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curso.Biblioteca.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorialController : ControllerBase, IEditorialServicio
    {
        private readonly IEditorialServicio editorialServicio;

        public EditorialController(IEditorialServicio editorialServicio)
        {
            this.editorialServicio = editorialServicio;
        }

        [HttpGet]
        public async Task<ICollection<EditorialDto>> GetAllAsync()
        {
            return await editorialServicio.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<EditorialDto> GetByIdAsync(int id)
        {
            return await editorialServicio.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<bool> CreateAsync(CrearEditorialDto crearEditorialDto)
        {
            return await editorialServicio.CreateAsync(crearEditorialDto);
        }

        [HttpPut("{id}")]
        public async Task<bool> UpdateAsync(int id, CrearEditorialDto editorialDto)
        {
            return await editorialServicio.UpdateAsync(id, editorialDto);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(int id)
        {
            return await editorialServicio.DeleteAsync(id);
        }
    }
}
