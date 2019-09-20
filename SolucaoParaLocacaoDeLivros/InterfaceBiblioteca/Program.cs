using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivroController livros = new LivroController();
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");
            while (!RealizarLoginSistema())
                Console.WriteLine("Login e senha inválidos");

            MostraMenuSistema();

            Console.ReadKey();
        }
        /// <summary>
        /// Mostra no console o meu menu disponivel do sistema.
        /// </summary>
        private static void MostraMenuSistema()
        {
            var menuEscolhido = int.MinValue;
            while (menuEscolhido != 0)
            {

                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                Console.WriteLine("Menu sistem");
                Console.WriteLine("1-Listar usuários");
                Console.WriteLine("2-Listar livros");
                Console.WriteLine("3-Cadastrar livros");
                Console.WriteLine("0- Sair");

                //Aqui vamos pegar o numero digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());


                //Executar proxima função

                switch (menuEscolhido)
                {
                    case 2:
                        MostrarLivro();
                        break;
                    case 3:
                        break;


                    case 0: return;
                    default:
                        break;


                }
            }

        }
        /// <summary>
        /// Metodo que realiza os procedimentos completos de login dentro do sistema como solicitação de logine senha pelo console
        /// assim como a respectiva validação que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados estiverem corretos</returns>
        private static bool RealizarLoginSistema()
        {
            Console.WriteLine("Informe seu ligin e senha para acessar o sistema:");

            Console.WriteLine("login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();
            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarioController.LoginSistema(usuario);
        }

        private static void MostrarLivro()
        {
            livros.Livros.ForEach(i =>
            Console.WriteLine($"nome do livro: {i.Nome}"));

            Console.ReadKey();

        }







    }       

    
}
