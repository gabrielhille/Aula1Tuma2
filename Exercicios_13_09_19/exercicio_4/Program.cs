using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4 /*Criar um console app que apresente a quantidade total de caracteres que contém em um texto informado
pelo usuário.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texot?");


            var caracter = Console.ReadLine();


            Console.WriteLine($" A quantidadde de caracteres do seu texto é: {caracter.Length}");
            Console.ReadKey();
        }
    }
}
