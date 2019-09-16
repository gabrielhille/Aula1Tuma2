using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoList
{
    class Program
    {
        static List<string> minhaListaPulgmatica = new List<string>()
            {
                "Felipe",
                "Irineu",
                "Serilop"
            };
        static void Main(string[] args)
        {
            AdicionarItensALista();
            minhaListaPulgmatica.Add(Console.ReadLine());
            ListaInformacoes();
            
            Console.ReadKey();


        }
        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("Informe um nome");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Deseja informar mais um nome (s) sim qualquer outra não");

            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AdicionarItensALista();
        }

        private static void ListaInformacoes()
        {
            Console.Clear();

            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine(item.ToUpper());
               Console.Write("Adicionado com sucesso");


        }
        

    }
}
