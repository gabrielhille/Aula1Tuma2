using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemCadastroLista.Model;

namespace SystemCadastroLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListaPessoas = new List<Pessoa>();

            var pessoa = new Pessoa();

            Console.WriteLine("Insira o nome da pessoa:");
            pessoa.NomePessoa = Console.ReadLine();

            Console.WriteLine("Insira a idade da pessoa:");
            pessoa.IdadePessoa = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o sexo da pessoa M ou F:");
            pessoa.SexoPessoa = char.Parse(Console.ReadLine());


            Console.WriteLine("Insira a altura da pessoa em mts");
            pessoa.AlturaPessoa = double.Parse(Console.ReadLine());

            ListaPessoas.Add(pessoa);


            ListaPessoas.ForEach(i =>

             Console.WriteLine($"Nome: {i.NomePessoa}, Idade: {i.IdadePessoa} anos, Sexo: {i.SexoPessoa} Altura: {i.AlturaPessoa} Mts"));

            Console.ReadKey();



        }
    }
}
