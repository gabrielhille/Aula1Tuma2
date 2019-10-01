using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3 /*Criar um console app que solicite o nome e a idade, e após informar nome e idade o mesmo
deverá apresentar quando maior ou igual a 18 anos a seguinte informação:"Parabéns {nome} você já esta na fase adulta."
caso menor de 18 anos o mesmo deverá apresentar a seguinte informação:"Parabéns {nome} você já esta na fase adulta."
caso menor de 18 anos o mesmo deverá apresentar a seguinte informação: */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();
            
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
                Console.WriteLine($"Parabéns {nome} você já esta na fase adulta.");
            else
                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");






            Console.ReadKey();


        }
    }
}
