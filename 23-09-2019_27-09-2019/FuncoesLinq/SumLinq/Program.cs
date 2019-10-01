using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteiroPrimitivos();
            SomaInteirosLista();
            SomaBalasListaDeCriancas();

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra numeros inteiros por um tipo primitivo
        /// </summary>
        static void SomarInteiroPrimitivos()
        {
            //quando utilizamos "[]" em um tipo "primitivo" podemos criar uma colecao destes valores
            int[] colecaoInteiros =
                //alocamos a memoria para a nossa colecao de valor e informamos a quantidade de memoria que vamos ocupar
                //memoriaOcupadaInt * quantidadeInformada
                new int[5] 
            //Aqui carregamos nossa colecao de valores
            {1,2,3,4,5 };

            //Aqui somamos os valores em nossa lista
            Console.WriteLine(colecaoInteiros.Sum());

        }
        /// <summary>
        /// metodo que soma valores em uma lista
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13
            };

            Console.WriteLine(listaDeInteiros.Sum());
        }
        /// <summary>
        /// Metodo que soma a quantidade de balas das crianças
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            List<Crianca> criancas = new List<Crianca>()
            {
                new Crianca()
                {
                    Nome = "Joaozinho",
                    Balas = 9
                },
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }

            };
            Console.WriteLine("Quantidade total de balas qu as criancas levaram da venda ");
            Console.WriteLine(criancas.Sum(x => x.Balas));

        }
    }
}
