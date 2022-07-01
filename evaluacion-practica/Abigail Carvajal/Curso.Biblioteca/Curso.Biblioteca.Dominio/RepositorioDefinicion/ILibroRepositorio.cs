﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.RepositorioDefinicion
{
    public interface ILibroRepositorio
    {
        IQueryable<Libro> GetAll();
        Task CreateAsync(Libro libro);
        Task DeleteAsync(Libro libro);
        Task UpdateAsync(Libro libro);
    }
}
