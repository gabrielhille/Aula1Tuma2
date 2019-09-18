using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class Carros
    {
        public static void ListaDeCarros()
        {

            var listaCar = new List<string>();

            listaCar.Add("FIAT");
            listaCar.Add("VOLKSWAGEN ");
            listaCar.Add("CHEVROLET");
            listaCar.Add("FORD");
            listaCar.Add("NISSAN");
            listaCar.Add("KIA");
            listaCar.Add("BMW");
            listaCar.Add("ALFA ROMEU");
            listaCar.Add("BENTLEY");
            listaCar.Add("SUBARU");

            listaCar.ForEach(i => Console.WriteLine($"As marcas listadas são: {i}"));

            Console.WriteLine("-------------------------------");
        }



    }
}
