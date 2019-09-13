using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5 /*Criar um console app que apresente o primeiro e o ultimo caractere de uma palavra informada.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a palavra");
            var palavra = Console.ReadLine();
            var l1 = palavra[0];
            var l2 = palavra[palavra.Length - 1];


            Console.WriteLine($" A primeira e a ultima pletra da sua palavra são: {l1} , {l2}");
            Console.ReadKey();

        }
    }
}
