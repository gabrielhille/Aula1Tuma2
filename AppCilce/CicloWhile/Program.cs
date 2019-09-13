﻿using System;
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

           

            while(AskToContinue () == 1)
            {
                VocePodeBeber();
            }
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
        private static void VocePodeBeber()
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if( idade < 18)
             Console.WriteLine("você não pode beber");
            else
                Console.WriteLine("você pode beber");










        }
         

    }

}
