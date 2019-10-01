using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoInformacao
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
            
            


        }
        /// <summary>
        /// Menu do sistema
        /// </summary>
        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine("");

            Console.WriteLine("(1)-Calculo de area:");
            Console.WriteLine("(2)-Mostrar animação:");
            Console.WriteLine("(3)-Lista de carros:");
            Console.WriteLine("(4)-Lista de creveja");
            Console.WriteLine("(5)-Calculo de IMC");
            Console.WriteLine("(6)-Sair do sistema:");
            Console.WriteLine("---------------------");


            var MenuEscolhido = int.Parse(Console.ReadLine());

            switch(MenuEscolhido)
            {
                case 1:
                    { CalculaArea(); MenuSistema(); }
                    break;

                case 2:  var meuDesenho = new desenho();
                    meuDesenho.MinhaAnimacao();
                    MenuSistema();
                    break;
                case 3:    Carros.ListaDeCarros();
                    MenuSistema();
                    break;
                case 4:
                    Cervejas.ListaDeCerveja();
                    MenuSistema();
                    break;

                case 5:
                    CalculoDeIMC.CalculoIMC();
                    MenuSistema();
                    break;

                case 6: {
                        Console.WriteLine("Numero invalido");
                    }
                    break;

                default:
                    break;

            }
            
        }

        /// <summary>
        /// Calculo de area
        /// </summary>
        public static void CalculaArea()
        {
            Console.WriteLine("Informar o dado do quadrado: ");
            var ladoQuadrado = double.Parse( Console.ReadLine());

            var bibliotecaCalculos = new CalculosDeArea();

            Console.WriteLine($"Minha area é de {bibliotecaCalculos.CalculaAreaDoQquadrado(ladoQuadrado)}");

            Console.ReadKey();

        }





    }
}
