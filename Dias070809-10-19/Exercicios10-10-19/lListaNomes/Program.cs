using ListagemDeNomes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeNomes.Controller;

namespace lListaNomes
{
    class Program
    {

        static ListagemController listagemController = new ListagemController();
 
        static void Main(string[] args)

        {

            Console.WriteLine("SISTEMA DE Nomes");

            MostraMenuSistema();

        }

        private static void MostraMenuSistema()

        {

            var menuEscolhido = int.MinValue;



            while (menuEscolhido != 0)

            {

                Console.Clear();

                Console.WriteLine("Menu sistema");

                Console.WriteLine("1 - Inserir Nomes");

                Console.WriteLine("2 - Listar Nomes");


              var menu = int.Parse(Console.ReadLine());


                switch (menu)
                {
                    case 1:
                        AdicionarNome();
                        break;


                    case 2:
                        MostrarNomes();
                        break;


                }

            }
        }


        public static void AdicionarNome()
        {
            Console.WriteLine("Cadastrar nome dentro do sistema!");
            Console.WriteLine("Nome do nome para cadastro:");
            var nomenome = Console.ReadLine();
            var resposta = listagemController.AdicionarNome(new Nomes()
            {
                Nome = nomenome
            });

            if (resposta)
                Console.WriteLine("Nome sucefulll");
            else
                Console.WriteLine("Merda");
    }




        public static void MostrarNomes()
        {
            Console.WriteLine("-Lista de nomes-");
            listagemController.RetornaListaDeNomes().ToList<Nomes>().ForEach(x => Console.WriteLine($"Nome : {x.Nome}"));

            Console.ReadKey();

        }
    }
}



        
   

