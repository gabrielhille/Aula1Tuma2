using ListaCadastroDeCarros.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCadastroDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Cadastro de carro  (2) Alteração de placas (0)  sair");
            var resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    var ListaPessoas = new List<ListaCarro>();
                    var carros = new ListaCarro();

                    Console.WriteLine("Insira a marca do carro:");
                    carros.MarcaCarro = Console.ReadLine();

                    Console.WriteLine("Insira o modelo do carro:");
                    carros.ModeloCarro = Console.ReadLine();

                    Console.WriteLine("Insira o ano do carro:");
                    carros.AnoCarro = int.Parse(Console.ReadLine());


                    Console.WriteLine("Insira o valor do carro");
                    carros.ValorCarro = double.Parse(Console.ReadLine());

                    ListaPessoas.Add(carros);


                    ListaPessoas.ForEach(i =>

                     Console.WriteLine($"Marca do Carro: {i.MarcaCarro}, Modelo: {i.ModeloCarro},Ano: {i.AnoCarro} valor R$:{i.ValorCarro} "));
                    break;
                case 2:
                    Console.WriteLine("Insira as letras da placa");
                    var letraplaca = Console.ReadLine();

                    Console.WriteLine("Insira o primeiro numero da placa ");
                    var numeroPlaca1 = char.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo numero da placa ");
                    var numeroPlaca2 = int.Parse(Console.ReadLine());
                    string letraFinala = "A";
                    string letraFinalb = "B";
                    string letraFinalc = "C";
                    string letraFinald = "D";
                    string letraFinale = "E";
                    string letraFinalf = "F";
                    string letraFinalg = "G";
                    string letraFinalh = "H";
                    string letraFinali = "I";
                    string letraFinalj = "J";
                    string letraFinal = "A";
                    if (numeroPlaca2 == 0)
                         letraFinal = letraFinala;
                    if (numeroPlaca2 == 1)
                        letraFinal = letraFinalb ;
                    if (numeroPlaca2 == 2)
                        letraFinal = letraFinalc;
                    if (numeroPlaca2 == 3)
                        letraFinal = letraFinald;
                    if (numeroPlaca2 == 4)
                        letraFinal = letraFinale;
                    if (numeroPlaca2 == 5)
                        letraFinal = letraFinalf;
                    if (numeroPlaca2 == 6)
                        letraFinal = letraFinalg;
                    if (numeroPlaca2 == 7)
                        letraFinal = letraFinalh;
                    if (numeroPlaca2 == 8)
                        letraFinal = letraFinali;
                    if (numeroPlaca2 == 9)
                        letraFinal = letraFinalj;

                    Console.WriteLine("Insira o terceiro numero da placa ");
                    var numeroPlaca3 = Console.ReadLine();
                    Console.WriteLine("Insira o quarto numero da placa ");
                    var numeroPlaca4 = Console.ReadLine();
                    

                    Console.WriteLine($"Placa atualizada é:{letraplaca}-{numeroPlaca1}{letraFinal}{numeroPlaca3}{numeroPlaca4}");
                    Console.ReadKey();




                    Console.ReadKey();

                    break;
                    
                    
                    


            }
                  
        }
         
        
    }
}
