using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.model;

namespace LocacaoBiblioteca.Controller
{
    public class LivroController
    {
        private int Idcontador = 0; 
        public LivroController()
        {
            ListaDeLivros = new List<Livro>();
            ListaDeLivros.Add(new Livro()
            {
                Id = Idcontador++,
                Nome = "Meu Primeiro Livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = Idcontador++,
                Nome = "Meu segundo livro"
            });
        }
        
        private List<Livro> ListaDeLivros { get ; set ; }
        /// <summary>
        /// Metodo que adiciona em nossa lista ja "instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informação do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = Idcontador++;
            ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return ListaDeLivros;
        }
       
    }

}
