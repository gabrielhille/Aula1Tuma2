using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComLista();
        }

        private static void iniciandoForeach01()
        {
            Console.WriteLine("Informar o texto:");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'a')
                    continue;

                Console.WriteLine(item);

            }
            Console.ReadKey();


        }
        
        /// <summary>
        /// metodo de busca com split e informando o nome 
        /// dando a quantidade de vezes que a mesma foi achada no texto
        /// </summary>
        private static void ForeachComSplit()
        {
            Console.WriteLine("informe o texto:");
            var conteudoDoTexto = Console.ReadLine();

            Console.WriteLine("informe a palavra para realizar a busca:");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(' ');
            var coutPalavra = 0;

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    //Console.WriteLine("Palavra encontrada com sucesso");
                coutPalavra++;

            }
            Console.WriteLine($"Quantida de vezes que a palavra {palavra} aparece é: {coutPalavra}");
            Console.ReadKey();

        }         

        private static void ForeachComLista ()
        {
            var conteudo = "nome:Gabriel,idade:29;nome:Giomar,idade:75;nome:Eusebio,idade:30";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuarios cadastrados no sistema:");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
                
            }
            Console.WriteLine("Informaçoes do sistema");
            var nomeBusca = Console.ReadLine();



            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');

                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                    Console.WriteLine($" O {nome} tem {idade} anos.");

                   
            }

            Console.ReadLine();


        }
    }
}
