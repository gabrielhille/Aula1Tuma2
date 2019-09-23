using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Clase que contem os metodos de usúario do sistema
    /// </summary>
    public class UsuarioController
    {
        //Criando privado para impedir que o programador de adicionar um ID ou alterar fora da classe
        private int Idcontador = 0;
        
        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// -Login: Admin
        /// -Senha: admin
        /// </summary>
        /// <param name="usuarios">Passamos um objeto de nome Usuario como parametro</param>
        /// <returns>Retorna verdadeiro quando existir o usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            return ListaDeUsuarios.Exists(x =>
            x.Login == usuarios.Login
            && x.Senha == usuarios.Login);


        }

        public  List<Usuario> ListaDeUsuarios { get ; set; }
        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();
            ListaDeUsuarios.Add(new Usuario()
            {
                //Adiciona o Id contador incermentando o mesmo com ele +1 "++"
                Id = Idcontador++,
                Login = "Gabriel",
                Senha = "Gabriel"
            }) ;
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = Idcontador++,
                Login = "Admin",
                Senha = "Admin"
            });

        }
        public void AdicionarUsuario(Usuario parametroUsuario)
        {
            parametroUsuario.Id = Idcontador++;
            //Adiciono o meu usuario a minha lista
            ListaDeUsuarios.Add(parametroUsuario);

        }
        public List<Usuario> RetornaListaDeUsuarios()
        {
            return ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }

        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que sera desativado</param>
        /// com isso conseguimos acessar as propriedades dele e desativar o registro
        public void RemoverUsuarioPorID(int identificadoID)
        {
            ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }
    }
}
