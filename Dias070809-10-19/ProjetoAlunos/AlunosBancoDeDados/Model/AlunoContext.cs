using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunosBancoDeDado;

namespace AlunosBancoDeDado.Model
{
    public class AlunoContext:
        DbContext

    {

        public DbSet <Aluno> listaDeAlunos
        { get; set; } 

    }
}
