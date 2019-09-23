using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.model;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivroController livrosController = new LivroController();
        static UsuarioController usuarioController = new UsuarioController();
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
                Console.WriteLine("1-Listar Usuários");
                Console.WriteLine("2-Listar Livros");
                Console.WriteLine("3-Cadastrar Livros");
                Console.WriteLine("4-Cadastrar Usuarios");
                Console.WriteLine("5-Fazer Logoof");
                Console.WriteLine("6- Remover Usuario");
                Console.WriteLine("0- Sair");

                //Aqui vamos pegar o numero digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());


                //Executar proxima função

                switch (menuEscolhido)
                {
                    case 1:
                        MostrarUsuarios();
                        break;

                    case 2:
                        MostrarLivro();
                        break;

                    case 3:
                        AdicionarLivro();
                        break;

                    case 4:
                        AdicionarUsuario();
                            break;

                    case 5:
                        while (!RealizarLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        break;

                    case 6:
                        RemoverUsuarioPeloID();
                        break;


                    case 0: return;
                    default:
                        break;


                }
            }

        }
        private static void RemoverUsuarioPeloID()
        {
            Console.WriteLine("Remover um usuario pelo Id no sistema");
            //Metodo que mostra os usuarios criado anteriormente
            MostrarUsuarios();
            Console.WriteLine("Informe o Id para desativar do sistema");
                var usuarioID = int.Parse(Console.ReadLine());
            //Aqui chamamos RemoverUsuarioPorID da nossa classe que controla os usuarios do sistema
            usuarioController.RemoverUsuarioPorID(usuarioID);

            //Informamos que o usuario foi desativado com sucesso
            Console.WriteLine("Usuario desativado com sucesso");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que adiciona um novo usuario no sistema pelo console
        /// </summary>
        private static void AdicionarUsuario()
        {
            Console.WriteLine("Cadastrar usuario dentro do sistema");

            Console.WriteLine("Nome do usuario");
            var nomeDoUsuario = (Console.ReadLine());

            Console.WriteLine($"Cadastrar a senha do usuario { nomeDoUsuario }");
            var senhaUsuario = (Console.ReadLine());


            usuarioController.AdicionarUsuario(new Usuario()
            {
                Login = nomeDoUsuario,
                Senha = senhaUsuario

            }) ;
            Console.WriteLine("Usuario cadastrado com sucesso");
            Console.ReadKey();

        }
        
        /// <summary>
        /// Metodo que adiciona dentro da nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            //Identificamos que o mesmo esta na parte de cadastro de livro do sistema
            Console.WriteLine("Cadastrar livro dentro do sistema");
            //Informamos que para dar continuidade ele deve informar um nome para o livro
            Console.WriteLine("Nome do livro");
            //Obtemos essa informação do usuario
            var nomeDoLivro = (Console.ReadLine());
            //"Livros Controller" livros controle nosso "objeto" em memoria com isso temos disponivel nele ferramentas que nos ajudam a 
            //realizar tarefas como adicionar um item a nossa lista

            livrosController.AdicionarLivro(new Livro()
            {
                //Aqui Atribuimos o nome que demos ao livro na propriedade Nome do nosso livro com o sinal de apenas um "=" temos
                //atribuição, passagem de valor
                Nome = nomeDoLivro
            }) ;
            //Indica que finalizamos o processo de cadastro do livro, assim o usuario já sabe que o mesmo foi realizado com sucesso.
            Console.WriteLine("Livro cadastrado com sucesso");
            //Apenas para que ele visualize essa informação.
            Console.ReadKey();


        }
        /// <summary>
        /// Metodo que realiza os procedimentos completos de login dentro do sistema como solicitação de logine senha pelo console
        /// assim como a respectiva validação que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados estiverem corretos</returns>
        private static bool RealizarLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            
            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarioController.LoginSistema(usuario);
        }

        private static void MostrarLivro()
        {
            livrosController.RetornaListaDeLivros().ForEach(i =>
            Console.WriteLine($"Id: {i.Id} Nome do livro: {i.Nome}"));

            Console.ReadKey();

        }
        private static void MostrarUsuarios()
        {
            usuarioController.RetornaListaDeUsuarios().ForEach(i =>
           Console.WriteLine($"Id: { i.Id} Login do usuario: {i.Login} "));
            Console.ReadKey();

        }
    }       
   
}
