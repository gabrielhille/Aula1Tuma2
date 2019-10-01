using ListaDeAmigos2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeAmigos2
{
    class Program
    {
        static void Main(string[] args)
        {
            var MinhaListaAmigos = new List<Amigos>();

            MinhaListaAmigos.Add(new Amigos()
            {
                NomeAmigos = "Thiago",
                TempoDeAmizade = 18
            });
            MinhaListaAmigos.Add(new Amigos()
            {
                NomeAmigos = "Frank",
                TempoDeAmizade = 10
            });
            MinhaListaAmigos.Add(new Amigos()
            {
                NomeAmigos = "Andre",
                TempoDeAmizade = 10
            });

            MinhaListaAmigos.ForEach(i => Console.WriteLine($"Nome do amigo: {i.NomeAmigos} Tempo de Amizade: {i.TempoDeAmizade}"));

            Console.ReadKey();

        }

    }
}
