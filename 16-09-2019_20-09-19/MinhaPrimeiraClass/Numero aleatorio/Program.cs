using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random rdm = new Random();
           
            for (int i = 0; i < 10; i++)
            {
                // Gera um numero aleatoriamente
                int valorGeradoAleatoriamente = rdm.Next(100);

                //Verifica se a lista não contem este numero gerado
               if(!numeros.Contains(valorGeradoAleatoriamente))
                {

                    numeros.Add(valorGeradoAleatoriamente);
                }
                else
                {
                    i--;
                }


                numeros.Add(valorGeradoAleatoriamente);
                
            }
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
