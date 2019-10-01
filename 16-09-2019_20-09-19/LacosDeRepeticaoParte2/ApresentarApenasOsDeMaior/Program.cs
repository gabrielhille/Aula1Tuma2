using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentarApenasOsDeMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuarios cadastrados no sistema:");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);

            }
            Console.Write("Insira o nome: ");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');

                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (int.Parse(idade) >= 18 && nomeBusca == nome)
                    Console.WriteLine($"o {nome} é maior de 18 anos");
                if (int.Parse(idade) <= 18 && nomeBusca == nome)
                    Console.WriteLine($"{nome} é menor de 18 anos.");

            }

            Console.ReadLine();

        }
    }
}
