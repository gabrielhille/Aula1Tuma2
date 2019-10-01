using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //texto imformativo para consultar o livro
            //pelo numero de registro do sistema
            Console.WriteLine ("Informe o livro a ser consultado:");
            //parte do codigo recebe as informaçãoes
            //de registro do livro e coloca na variavel
            //numeroDoLivro para utilizar
            var numeroDoLivro = Console.ReadLine();
            //aqui realizo a comparação das informações 
            //do livro em estoque
            if(numeroDoLivro == "123456")
            {
                //informo que este livro ja esta locado
                Console.WriteLine(" Lvro indisponivel");
                Console.ReadKey();
                //Finaliza o metodo
                return;

            }
            else
            {
                Console.WriteLine(" deseja alocar o livro? (1)sim  (2)nao");
                var resposta =Console.ReadLine();
                if(resposta=="1")
                {
                    Console.WriteLine("Livro alocado");
                    Console.ReadKey();
                    return; 

                }


            }


            Console.ReadKey();

        }
    }
}
