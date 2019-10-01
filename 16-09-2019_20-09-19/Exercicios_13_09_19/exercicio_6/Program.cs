using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_6 /*Criar um console app que quando informado o texto contendo banana ele troque esta informação
por laranja.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto?");
            var texto = Console.ReadLine();
            trocaPalavra(texto);

            Console.ReadKey();
        }
        private static void trocaPalavra(string texto)
        {
         Console.WriteLine(texto.Replace("banana", "laranja"));

        }
            

        
    }
}
