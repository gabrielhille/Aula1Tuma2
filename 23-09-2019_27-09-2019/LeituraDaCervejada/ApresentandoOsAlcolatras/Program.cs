using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ApresentandoOsAlcolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.AdicionaCervejasNaLista(new Cerveja(1, "Giomar",0.6,5.5,9.9));
            //{
            //    Id = cervejaController.RetornaListaDeCerveja().Count + 1,
            //    Nome = "Giomar",
            //    Litros = 0.6,
            //    Alcool = 5.5,
            //    Valor = 9.9
            //}); ;

            cervejaController.RetornaListaDeCerveja().
                ForEach(x => Console.WriteLine($" {x.Id}  {x.Nome}  {x.Litros}  {x.Alcool}  {x.Valor}"));

            Console.ReadKey();

        }
    }
}
