﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosBancoDeDado.Model
{
   public class Aluno
    {

        [Key]

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

    }
}
