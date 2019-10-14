using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Inicialmente devemos deixar a classe publica
    public class Cerveja
    {
        //Chama pelo (control + ".")
        [Key] //Chave primaria, auto incrementa
        public int Id { get; set; }
        [StringLength(50)] //Quantidade maxima de caracteres da variavel abaixo
        [Required] //Especifica se o campo é notnull 
        public string Nome { get; set; }
        [StringLength(30)]
        public string Tipo { get; set; }

        public double Teor { get; set; }
    }
}
