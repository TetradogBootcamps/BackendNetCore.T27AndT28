﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL.Models
{
    public class Proveedor
    {
        [MaxLength(4)]
        public string Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
    }
}
