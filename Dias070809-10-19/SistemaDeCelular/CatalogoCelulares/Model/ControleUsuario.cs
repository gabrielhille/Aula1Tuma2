using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
   public class ControleUsuario
    {
        public bool Ativo { get; set; } = true; //define falor default 'true' 
        public int UsuarioCriacao { get; set; } = 0;//define falor default '0' 
        public int UsuarioAlteracao { get; set; } = 0;//define falor default '0' 
        public DateTime DataCriacao { get; set; } = DateTime.Now; // define data atual
        public DateTime DataAlteracao { get; set; } = DateTime.Now; //define data atual
    }
}
