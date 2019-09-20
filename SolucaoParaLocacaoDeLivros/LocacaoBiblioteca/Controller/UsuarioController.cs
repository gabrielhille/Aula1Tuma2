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
            if (usuarios.Login == "Admin" && usuarios.Senha == "Admin")
                return true;
            
            else
                return false;

        }

        public  List<Usuario> Usuarios { get ; set; }
        public UsuarioController()
        {
            Usuarios = new List<Usuario>();
            Usuarios.Add(new Usuario()
            {
                Login = "Gabriel",
                Senha = "Gabriel"
            });
            Usuarios.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin"
            });
        }
    }
}
