using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_de_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual calculo necessario? (1) area (2) volume (3) circunferencia (4) Área do Círculo (5) Calculo do IMC (0) Encerra  ");
            var resposta = int.Parse(Console.ReadLine());


            while (resposta != 0)
            {
                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("Digite o comprimento: ");
                        var comprimento = Console.ReadLine();
                        Console.WriteLine("digite largura:");
                        var largura = Console.ReadLine();
                        var area = double.Parse(comprimento) * double.Parse(largura);
                        Console.WriteLine($"a area é igual á '{area}' M2");
                        break;

                    case 2:
                        Console.WriteLine("Digite o comprimento: ");
                        var comprimento2 = Console.ReadLine();
                        Console.WriteLine("digite largura:");
                        var largura2 = Console.ReadLine();
                        Console.WriteLine("digite a profundidade:");
                        var profundidade = Console.ReadLine();
                        var volume = double.Parse(comprimento2) * double.Parse(largura2) * double.Parse(profundidade);
                        Console.WriteLine($"a area é igual á '{volume}' m3");
                        break;

                    case 3:
                        Console.WriteLine("Digite o raio: ");
                        var raio2 = Console.ReadLine();
                        var circunferencia = double.Parse(raio2) * 6.283158;
                        Console.WriteLine($"a circunferencia é '{circunferencia}'");
                        break;

                    case 4:
                        Console.WriteLine("Digite o raio: ");
                        var raio3 = Console.ReadLine();
                        var areacirculo = double.Parse(raio3) * double.Parse(raio3) * 3.1416;
                        Console.WriteLine($" Área do Círculo é :'{areacirculo}'");
                        break;

                    case 5:
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
                        break;
                }
                Console.WriteLine("Qual calculo necessario? (1) area (2) volume (3) circunferencia (4) Área do Círculo (5) Calculo do IMC (0) Encerra  ");
                resposta = int.Parse(Console.ReadLine());



            }




        }
    }
}
