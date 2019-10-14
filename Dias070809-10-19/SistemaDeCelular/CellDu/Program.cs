using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;

namespace CellDu
{
    class Program
    {
        //1- Colocar console App para startar o projeto
        //2- Adicionar referencia CatalogoCelulares
        //3- Adicionar o entity em nosso projeto
        //4- Adicionar o using ao nosso projeto

        static CelularesController celulares = new CelularesController();


        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while(opcao != 0)
            {
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1- Inserir um celular");
                Console.WriteLine("2- Atualizar um celular");
                Console.WriteLine("3- Remover um celular");
                Console.WriteLine("4- Listar celulares");
                Console.WriteLine("0- Sair");



                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        InseririCelular();
                        break;

                    case 2:
                        AtualizarCelular();

                        break;

                    case 3:
                        RemoverCelular();
                            break;
                    case 4:
                        LIstarCelular();
                            break;

                    case 0:
                        Console.WriteLine("Saindo do sistema");
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                            break;

                }

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                Console.ReadKey(true);
                Console.Clear();
            }

        }

        
        //inserir
        public static void InseririCelular()
        {
            Console.WriteLine("--Inserir Celular--");
            Console.WriteLine("Informe a marca do celular");
            var marca = Console.ReadLine();

            
            Console.WriteLine("Informe o modelo do celular");
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o valor do celular");
            var preco = double.Parse(Console.ReadLine());

            var resultado = celulares.InserirCelular(new Celular()
                {
                Marca = marca,
                Modelo = modelo,
                Preco = preco

               
            });
            //verificamos o resultado se verdadeiro ou falso
            if (resultado)
                Console.WriteLine("Celular cadastrado com sucesso"); //mensagem que aparece se verdadeiro
            else
                Console.WriteLine("Erro ao cadastrar aparelho");  //mensagem que aparece se Falso


        }


        //atualizar
        public static void AtualizarCelular()
        {
            Console.WriteLine("--Atualizar Celular--");

            LIstarCelular();

            Console.WriteLine("Informe o Id para Alteração de registros");
            var celularId = int.Parse(Console.ReadLine());

            var celular = celulares.GetCelulares().FirstOrDefault(x => x.Id == celularId);

            if (celular == null)
            {
                Console.WriteLine("Id informado invalido");
                return;
            }


            Console.WriteLine("Informe a marca do celular");
            celular.Marca = Console.ReadLine();


            Console.WriteLine("Informe o modelo do celular");
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o valor do celular");
            celular.Preco = double.Parse(Console.ReadLine());

            var resultado = celulares   //nossa controller
                .AtualizarCelular(celular);


            //Parte final que mostramos o resultado do processo de atualização
            if(resultado)
                Console.WriteLine("Celular atualizado com sucsso");
            else
                Console.WriteLine("Erro ao atualizar aparelho");

        }
        //remover
        public static void RemoverCelular()
        {
            Console.WriteLine("--Remover Celular--");

            LIstarCelular();

            Console.WriteLine("Informe o Id para remoção de registros");
            var celularId = int.Parse(Console.ReadLine());

            var resultado = celulares.RemoverCelular(celularId);
            if (resultado)
                Console.WriteLine("Celular removido com sucesso");
            else
                Console.WriteLine("Erro ao remover o celular");
        }

        //listar
        public static void LIstarCelular()
        {
            Console.WriteLine("--Listar Celular--");

            celulares.GetCelulares()
                .ToList<Celular>()
                .ForEach(x =>
                Console.WriteLine($"Id:{x.Id} Marca:{x.Marca} Modelo:{x.Modelo} Preço : {x.Preco}"));
        }


        
    }
}
