using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> vendas = new List<Venda>()
            {
                new Venda()
                {
                    Produto = "XIAOMI Lite 6 quad core 128gb",
                    Quantidade = 8,
                    Valor = 1200.75
                },
                new Venda()
                {
                    Produto = "SLIM 3500 APP",
                    Quantidade = 5,
                    Valor = 2800.96
                },
                new Venda()
                {
                    Produto = "IPHONE ",
                    Quantidade = 1,
                    Valor = 9999.99
                }
            };

            Console.WriteLine("Media de prdutos vendidos nesse mes");
            Console.WriteLine(vendas.Average(x => x.Quantidade));
            Console.WriteLine("Media de Vendas neste mês em R$");
            Console.WriteLine(vendas.Average(x=> (x.Quantidade * x.Valor)));


            Console.ReadKey();
        }
       
    }
}
