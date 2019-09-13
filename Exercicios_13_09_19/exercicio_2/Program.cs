using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2 /* Criar um console app que apresente as boas vindas, solicite o nome do usuário. completo e
mostre uma mensagem de boas vindas com o nome do usuário.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas vindas");
            Console.WriteLine("Insira seu nome completo");
            var nome = Console.ReadLine();

            Console.WriteLine($"Boas vindas {nome}");

            Console.ReadKey();
        }
    }
}
