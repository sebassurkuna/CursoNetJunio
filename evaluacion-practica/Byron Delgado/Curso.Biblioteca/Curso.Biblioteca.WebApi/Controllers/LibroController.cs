using Curso.Biblioteca.Aplicacion.Dtos;
using Curso.Biblioteca.Aplicacion.ServicioDefinicion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curso.Biblioteca.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase, ILibroServicio
    {
        private readonly ILibroServicio libroServicio;

        public LibroController(ILibroServicio libroServicio)
        {
            this.libroServicio = libroServicio;
        }

        [HttpGet]
        public async Task<ICollection<LibroDto>> GetAllAsync()
        {
            return await libroServicio.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<LibroDto> GetByIdAsync(int id)
        {
            return await libroServicio.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<bool> CreateAsync(CrearLibroDto crearLibroDto)
        {
            return await libroServicio.CreateAsync(crearLibroDto);
        }

        [HttpPut("{id}")]
        public async Task<bool> UpdateAsync(int id, CrearLibroDto libroDto)
        {
            return await libroServicio.UpdateAsync(id, libroDto);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(int id)
        {
            return await libroServicio.DeleteAsync(id);
        }
    }
}
