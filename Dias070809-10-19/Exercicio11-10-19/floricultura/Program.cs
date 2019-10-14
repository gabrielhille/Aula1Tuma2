using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloresController.Controller;
using FloresController.Model;
namespace floricultura
{
    class Program
    {

        static FloresController.Controller.FloresController floresController = new FloresController.Controller.FloresController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.WriteLine("Escolha um menu");

                Console.WriteLine("1- Inserir uma Flor");

                Console.WriteLine("2- Listage das flores");
                Console.WriteLine("0- Saia do menu");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)

                {

                    case 1:
                        InseririFlor();

                        break;

                    case 2:
                        LIstarFloresr();

                        break;

                    case 0:
                        return;
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");

                Console.ReadKey(true);

                Console.Clear();
            }
        }


        public static void InseririFlor()

        {

            Console.WriteLine("--Inserir Flor--");

            Console.WriteLine("Informe nome da Flor");

            var nome = Console.ReadLine();


            Console.WriteLine("Informe a quantidade de flores");

            var quantidade = int.Parse(Console.ReadLine());


            var resultado = floresController.CadastrarFlor(new Flores()
            {

                Nome = nome,

                Quantidade = quantidade


            });


            if (resultado)

               Console.WriteLine("Flor cadastrada com sucesso"); 

            else

               Console.WriteLine("Erro ao cadastrar a flor");  


        }
        public static void LIstarFloresr()
        {
            Console.WriteLine("--Listar Flores--");

            floresController.GetFlores().OrderByDescending(p => p.Quantidade).ToList()
                .ForEach(x => Console.WriteLine($" ID: {x.Id} , Nome: {x.Nome}, Quantidade: {x.Quantidade}"));

             

        }



    }
}
