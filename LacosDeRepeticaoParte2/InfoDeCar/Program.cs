using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoDeCar
{
    class Program
    {
        static void Main(string[] args)
        {
            autoForeach();
        }

        private static void autoForeach()
        {
            var conteudo = "Carro:Gol,Marca:Volkswagen,ano:2000;Carro:Jetta,Marca:Volkswagen,ano:2012;Carro:Sportage,Marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";

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
                var marca = informacoesSplit[1].Split(':')[1];
                var ano = informacoesSplit[2].Split(':')[1];
                if (nome == nomeBusca)
                    Console.WriteLine($" O {nome} é da marca marca {marca} ano {ano} .");


            }

            Console.ReadLine();
        }
    }
}
