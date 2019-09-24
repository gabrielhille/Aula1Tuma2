using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        public int IdcontadorLivros { get; set; } = 1;
        public int IdcontadorUsuarios { get; set; } = 1;
        public LocacaoContext ()
        {

            //criamos uma lista de livros em memoria
            ListaDeLivros = new List<Livro>();
            //criamos uma lista de livros em memoria
            ListaDeUsuarios = new List<Usuario>();


            //Adicionamos os livros 
            ListaDeLivros.Add(new Livro()
            {
                Id = IdcontadorLivros++,
                //Informo apenas o nome do livro para adicionar
                Nome = "Meu Primeiro Livro",
                Ativo = true

            });

            ListaDeLivros.Add(new Livro()
            {
                Id = IdcontadorLivros++,
                Nome = "Meu Segundo Livro",
                Ativo = true
            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdcontadorUsuarios++,
                Login = "admin",
                Senha = "admin"
            }) ;
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdcontadorUsuarios++,
                Login = "gabriel",
                Senha = "gabriel"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdcontadorUsuarios++,
                Login = "user",
                Senha = "user"
            });

        }


        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }

    }
}
