using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoDeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Infomre a medida do quandrado");
            var medida = int.Parse( Console.ReadLine());

            var final = medida * medida;

            Console.WriteLine($"O tamano é {final} M2");

            Console.ReadKey();


        }
    }
}
