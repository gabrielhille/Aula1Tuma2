using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunosBancoDeDado.Model;



namespace AlunosBancoDeDado.Controller
{
    public class AlunoController
    {
         AlunoContext ContextDB = new AlunoContext();


        public IQueryable<Aluno> GetAlunos()
        {
            return ContextDB.listaDeAlunos;
        }

        public void AddAluno(Aluno item)
        {
            ContextDB.listaDeAlunos.Add(item);

            ContextDB.SaveChanges();

        }

        
    }
}
