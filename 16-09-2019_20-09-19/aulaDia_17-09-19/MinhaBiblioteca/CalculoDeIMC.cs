using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
     public class CalculoDeIMC
    {
        public static void CalculoIMC()
        {
            Console.WriteLine("digite seu peso");
            var peso = Console.ReadLine();
            Console.WriteLine("digite sua altura");
            var altura = Console.ReadLine();
            var IMC = double.Parse(peso) / (double.Parse(altura) * double.Parse(altura));
            Console.WriteLine($"Seu IMC é :'{Math.Round(IMC, 2)}'");
            if (IMC < 18.4)
                Console.WriteLine(" Abaixo do peso");
            if (IMC > 18.4 && IMC <= 24.9)
                Console.WriteLine(" Peso normal ");
            if (IMC > 25 && IMC <= 29.9)
                Console.WriteLine(" Sobrepeso ");
            if (IMC > 30 && IMC <= 34.9)
                Console.WriteLine(" Obesidade 1 ");
            if (IMC > 35 && IMC <= 39.9)
                Console.WriteLine(" Obesidade 2 ");
            if (IMC > 40)
                Console.WriteLine(" Obesidade 3 ");

            Console.ReadKey();

            


        }
            

    }
}
