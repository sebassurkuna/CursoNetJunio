using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.IRepositoriosDefinicion
{
    public interface IAutorRepositorio
    {
        IQueryable<Autor> GetAllAsync();
        IQueryable<Autor> GetAll();
        Task CreateAsync(Autor autor);
        Task UpdateAsync(Autor autor);
        Task DeleteAsync(Autor autor);

    }
}
