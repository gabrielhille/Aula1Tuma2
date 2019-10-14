using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
   public class Usuario : ControleUsuario
    {
        [Key]  //identity(1,1)
        public int Id { get; set; }

        [MaxLength(50)] //Quantidade maxima de caracteres
        public string Nome { get; set; }

        [MaxLength(30)] //Quantidade maxima de caracteres
        [Required] //Obrica o usuario a imserção do login
        public string Login { get; set; }

        [MaxLength(30)] //Quantidade maxima de caracteres
        [Required] //Obrica o usuario a imserção da senha
        public string Senha { get; set; }
    }
}
