using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0;


           

            while(AskToContinue () == 1)
            {
               nome = AskToName();
               idade = VocePodeBeber(nome );


            }
            Console.WriteLine($"\r\nSuas informações: Nome {nome} e sua idade{idade}");
            Console.ReadKey();


        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("--Seja bem vindo--");
            Console.WriteLine("------------------");

        }

        /// <summary>
        /// metodo para realizar pergunta se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserido</returns>
        private static int AskToContinue()
        {
            Console.WriteLine("\r\nVamos conversar? sim(1) não(2)");
            return  int.Parse(Console.ReadKey().KeyChar.ToString());

        }
        /// <summary>
        /// pergunda a idade do usuario
        /// retorne se ele pode beber </summary>

        private static int VocePodeBeber(string nome)
        {

            Console.WriteLine("\r\nQual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if( idade < 18)
             Console.WriteLine("\r\nVocê não pode beber");
            else
                Console.WriteLine($"\r\nBora{nome}, fdbora toma uma");
            return idade;

        }
        /// <summary>
        /// metodo para perguntar o nome
        /// </summary>
        /// <returns>retorna o nome informado</returns>
        private static string AskToName()
        {

            Console.WriteLine("\r\n Qual seu nome?");
            return Console.ReadLine();

        }
         

    }

}
