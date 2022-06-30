﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.ComercioElectronico.Dominio.Entities.Base
{
    public class BaseEntity
    {
        public bool IsDeleted { get; set; } = false;

        public DateTime CreationDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}
