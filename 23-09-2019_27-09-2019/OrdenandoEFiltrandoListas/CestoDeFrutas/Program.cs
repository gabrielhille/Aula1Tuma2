using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestoDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Fruta>();

            //Tomate
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            //Goiaba
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            //Manga
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarela",
                Peso = 325
            });

            cestaDeFrutas.OrderByDescending(X => X.Id).ToList<Fruta>().
                ForEach(i =>
                Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} peso: {i.Peso}"));

            Console.WriteLine("----------------------------------------");

            cestaDeFrutas.OrderBy(X => X.Id).ToList<Fruta>().
               ForEach(i =>
               Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} peso: {i.Peso}"));


            Console.WriteLine("----------------------------------------");

            var filtroCesta = cestaDeFrutas
                //Aqui filtramos os registros maiores que 100 gramas
                .Where(x => x.Peso > 100).
                //ordenamos esses valores pelo nome
                OrderBy(x=> x.Nome);
            
            //Aqui filtramos os registros maiores que 100 gramas
            filtroCesta.ToList<Fruta>()
                .ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome} Peso {i.Peso}"));
            #region lista 3
            //frutinha recebe cada fruta de nossa cesta
            (from frutinha in cestaDeFrutas //<- aqui temos a coleção de frutas
             where frutinha.Peso>100 //<- aqui escolhemos a fruta com mais de 100 g
             select frutinha) //Neste ponto eu junto as informações que
             .ToList<Fruta>()
             .ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome}"));
            #endregion lista 3

            //Aqui criamos a variavel que recebe o valor buscado
            var mostrandoFind = cestaDeFrutas
                //Aqui é feito o filtro das informações por uma "ou- -->||<---" outra cor 
                .Find(x => x.Cor == "Amrelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id {mostrandoFind.Id} Nome {mostrandoFind.Nome}");

            var mostrandoFindAll = cestaDeFrutas.FindAll(x => x.Cor == "Amrelo" || x.Cor == "Vermelho");
            Console.WriteLine("----------------------------------------");

            var cestaDeFrutasFindOrder = cestaDeFrutas.OrderBy(x => x.Nome)
                .ToList<Fruta>().Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id {cestaDeFrutasFindOrder.Id} Nome {cestaDeFrutasFindOrder.Nome}");


            Console.ReadKey();

        }


    }

}
