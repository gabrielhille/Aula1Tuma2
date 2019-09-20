using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livros.model;

namespace LocacaoBiblioteca.Controller
{
    public class LivroController
    {
        public LivroController()
        {
            Livros = new List<Livro>();
            Livros.Add(new Livro()
            {
                Nome = "Meu Primeiro Livro"
            });
            Livros.Add(new Livro()
            {
                Nome = "Meu segundo livro"
            });
        }
        
        public List<Livro> Livros { get ; set ; }
    }
}
