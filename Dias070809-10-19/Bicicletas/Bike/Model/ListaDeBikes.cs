using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike.Model
{
    public class ListaDeBikes : BikeControle
    {

        [Key]
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public double Valor { get; set; }
     



        //Id,Modelo,Marca,Valor
    }
}
