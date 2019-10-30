﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebImobiliaria.Models
{
    public class Proprietario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNas { get; set; }
        public string Email { get; set; }
    }
}