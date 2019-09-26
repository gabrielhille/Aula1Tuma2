using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;

namespace ListarCarrosDoAmigo
{
    class Program
    {
        static CarroController Controller = new CarroController();
        static void Main(string[] args)
        {
            Controller.GetCarros()
                .ForEach(i => Console.WriteLine($" Id: {i.Id} , Marca: {i.Marca} ,Cilindrada: {i.Cilindradas} ,Modelo: {i.Modelo} ,Portas: {i.Portas} "));
            Console.ReadKey();
        }     
    }
}
