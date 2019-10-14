using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionarContadorCasseID
{
    class Program
    {
        private const int V = 11;

        static void Main(string[] args)
        {
            

            var listaDePessoas = new List<Pessoas>();
            listaDePessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Spears    ",
                DataNascimento = DateTime.Parse(" 07/ 11 / 2004"),
                ValorCarteira = 846.96
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 2,
                Nome = "Swanson  ",
                DataNascimento = DateTime.Parse(" 20/ 06 / 2003"),
                ValorCarteira = 233.09
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 3,
                Nome = "Gray      ",
                DataNascimento = DateTime.Parse(" 03/12/2001"),
                ValorCarteira = 911.92
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 4,
                Nome = "Gregory   ",
                DataNascimento = DateTime.Parse(" 02/01/2000"),
                ValorCarteira = 469.01
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 5,
                Nome = "Olson     ",
                DataNascimento = DateTime.Parse("18/07/2001"),
                ValorCarteira = 261.90
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 6,
                Nome = "Garza     ",
                DataNascimento = DateTime.Parse("01/04/2000"),
                ValorCarteira = 360.41
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 7,
                Nome = "Sweet     ",
                DataNascimento = DateTime.Parse("12/03/2003"),
                ValorCarteira = 312.76
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 8,
                Nome = "Cline     ",
                DataNascimento = DateTime.Parse("26/03/2002"),
                ValorCarteira = 484.51
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 9,
                Nome = "Oliver    ",
                DataNascimento = DateTime.Parse("05/07/2004"),
                ValorCarteira = 513.76
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 10,
                Nome = "Vang      ",
                DataNascimento = DateTime.Parse("10/07/2000"),
                ValorCarteira = 271.05
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 11,
                Nome = "Maddox    ",
                DataNascimento = DateTime.Parse("29/05/2004"),
                ValorCarteira = 783.97
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 12,
                Nome = "Garrett   ",
                DataNascimento = DateTime.Parse(" 03/06/2006"),
                ValorCarteira = 154.11
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 13,
                Nome = "Mcintosh  ",
                DataNascimento = DateTime.Parse(" 06/07/2006"),
                ValorCarteira = 902.80
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 14,
                Nome = "Yang      ",
                DataNascimento = DateTime.Parse("29/04/2005"),
                ValorCarteira = 550.48
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 15,
                Nome = "Hendricks ",
                DataNascimento = DateTime.Parse("05/09/2003"),
                ValorCarteira = 410.56
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 16,
                Nome = "Cain      ",
                DataNascimento = DateTime.Parse("12/01/2002"),
                ValorCarteira = 221.13
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 17,
                Nome = "Blackburn ",
                DataNascimento = DateTime.Parse("10/05/2000"),
                ValorCarteira = 135.67
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 18,
                Nome = "Howe      ",
                DataNascimento = DateTime.Parse("27/09/2005"),
                ValorCarteira = 360.14
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 19,
                Nome = "Pratt     ",
                DataNascimento = DateTime.Parse("18/09/2000"),
                ValorCarteira = 991.83
            });
            listaDePessoas.Add(new Pessoas()
            {
                Id = 20,
                Nome = "Sherman   ",
                DataNascimento = DateTime.Parse("20/02/2003"),
                ValorCarteira = 667.00
            });


            var listaOrdenada = listaDePessoas.OrderBy(x => x.Nome);           
            foreach (var item in listaOrdenada)

                Console.WriteLine($"Id {item.Id} Nome {item.Nome} Carteira {item.ValorCarteira.ToString("N2")} Data nascimento: {item.DataNascimento.ToShortDateString()}.");

                                      

               Console.WriteLine("--------------------------------------------");

            var listaOrdenadaNascimento = listaDePessoas.OrderByDescending(x => x.DataNascimento);
            foreach (var item in listaOrdenadaNascimento)

                Console.WriteLine($"Id {item.Id} Nome {item.Nome} Carteira {item.ValorCarteira.ToString("N2")} Data de nascimento {item.DataNascimento.ToShortDateString()}");

            Console.WriteLine("-----------------------------------------------------------------");

            (from valorCarteira in listaDePessoas
             where valorCarteira.ValorCarteira > 500
             select valorCarteira)
             .ToList<Pessoas>()
             .ForEach(i => Console.WriteLine($"Nome com mais de 500   {i.Nome}  Valor {i.ValorCarteira.ToString("N2")}"));


            Console.WriteLine("-------------------------------------------------------------");


            (from idade in listaDePessoas
             where (DateTime.Today.Year - idade.DataNascimento.Year) >= 18
             select idade).ToList<Pessoas>()
             .ForEach(i => Console.WriteLine($"{i.Nome} é maior de 18 anos."));

            Console.WriteLine("-------------------------------------------------------------");

            (from idade in listaDePessoas
             where (DateTime.Today.Year - idade.DataNascimento.Year) <= 16
             select idade).ToList<Pessoas>()
             .ForEach(i => Console.WriteLine($"{i.Nome} é menor de 16 anos."));



            Console.ReadKey();


        }
    }
}
