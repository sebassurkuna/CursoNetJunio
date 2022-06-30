﻿using Curso.ComercioElectronico.Aplicacion.Dtos;
using Curso.ComercioElectronico.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.ComercioElectronico.Aplicacion.Services
{
    public interface IProductTypeAppService
    {

        Task<ICollection<ProductTypeDto>> GetAllAsync();

        Task<ProductTypeDto> GetAsync(string code);

        Task CreateAsync(CreateUpdateProductTypeDto productTypeDto);

        Task UpdateAsync(CreateUpdateProductTypeDto productTypeDto);

        Task DeleteAsync(string code);
    }
}
