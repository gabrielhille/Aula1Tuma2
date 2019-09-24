using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que controla as informações dos nossos livros
    /// </summary>
    public class LivrosController
    {
        private LocacaoContext contextDB = new LocacaoContext();
        
        /// <summary>
        /// Metodo construtor que prepara o terreo para já iniciar com livros pré cadastrados
        /// </summary>
        public LivrosController()
        {
           
        }
        
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instanciada" criada dentro do 
        /// construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista.
            parametroLivro.Id = contextDB.IdcontadorLivros++;
            parametroLivro.Ativo = true;
            contextDB.ListaDeLivros.Add(parametroLivro);

        }
        /// <summary>
        /// Metodo que retorna a lista de livros
        /// </summary>
        /// <returns>Lista de livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.FindAll(x=>x.Ativo==true);
        }
        public void RemoverLivrosPeloId(int identificadoID)
        {
            //Aqui usamos o metodo FirstOrDefaul para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e dasativar o registro
            contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }

    }
}
