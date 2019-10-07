using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunosBancoDeDado.Controller;
using AlunosBancoDeDado.Model;
namespace AcessandoAlunos
{
    class Program
    {
        public static AlunoController Alunos = new AlunoController();

        static void Main(string[] args)
        {
            Alunos.AddAluno(
                new Aluno()
                {
                    Nome = "Gabriel",
                    Idade = 29


                }) ;
            Alunos.GetAlunos()
                .ToList<Aluno>()
                .ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }

    }
}
