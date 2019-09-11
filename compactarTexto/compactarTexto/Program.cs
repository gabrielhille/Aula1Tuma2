using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compactarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Oi meu nome é Gabriel  e logo eu Gabriel tenho vontade de beber muito porque eu Gabriel  gosto de beber muito";
            Console.WriteLine(primeiroTexto);

            Console.WriteLine($"Texto contem : {primeiroTexto.Length} caracteres");
            primeiroTexto = primeiroTexto.Replace("Gabriel", "1").Replace("beber", "2").Replace("eu", "3"); 
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem : {primeiroTexto.Length} caracteres");
            Console.ReadKey();
        }
    }
}
