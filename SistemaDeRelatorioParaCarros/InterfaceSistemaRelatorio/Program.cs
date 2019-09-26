using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        { 
            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            MostraMenuRelatorio();

            vendasController.GetVendas().ForEach(i => IprimeInformacoes(i));
            
            Console.ReadKey();

        }

        private static void MostraMenuRelatorio()
        {
            Console.Clear();
            Console.WriteLine("Menu de relatórios");
            Console.WriteLine("1- Menu por periodo mensal");
            Console.WriteLine("0 - Sair ");

            var menuEscolhido = int.MinValue;
            while(menuEscolhido!= 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());
                switch (menuEscolhido)
                {
                    case 1: Console.WriteLine("Informe o mes para escolher o filtro");
                        var mesEscolhido = int.Parse(Console.ReadLine());

                        var listaDoPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);

                        var totalMes = listaDoPeriodoEscolhido.Sum(x => x.Valor * x.Quantidade);

                        var mediaPeriodo = listaDoPeriodoEscolhido.Average(x => x.Valor * x.Quantidade);

                        Console.WriteLine($"Total do mes {mesEscolhido} é { totalMes.ToString("C")}");
                        

                        Console.WriteLine($"Media do mes {mesEscolhido} é { mediaPeriodo.ToString("C")}");
                        Console.ReadKey();
                        
                        break;

                        
                }
                   
                

            }
        }
        public static void IprimeInformacoes(Venda vendas)
        {
            Console.WriteLine(string.Format("ID {0,5} Carro: {1, -35} Valor: {2, -13} Quantidade: {3,-3}  Data: {4, -13}"
                , vendas.Id, vendas.Carros, vendas.Valor.ToString("C"), vendas.Quantidade, vendas.Data.ToShortDateString()));
        }
    }
}
