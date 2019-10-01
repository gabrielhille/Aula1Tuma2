using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_7 /*riar um console app conte a quantidade de "a","e","i","o" e "u" dentro de um texto informado
pelo usuário.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = UserText();
            NumeroDeLetras(texto, "a");
            NumeroDeLetras(texto, "e");
            NumeroDeLetras(texto, "i");
            NumeroDeLetras(texto, "o");
            NumeroDeLetras(texto, "u");
            Console.ReadKey();

        }
        private static int AchaLetra(string texto, string letra)
        {
            var cont = 0;
            var textoLength = texto.Length;
            for (int i = 0; i < textoLength; i++)
            {
                if (texto[i].ToString() == letra)
                    cont++;
            }
            return cont;

        }

        private static void NumeroDeLetras(string texto, string letra)
        {
            Console.WriteLine($"\r\n Seu texto tem {AchaLetra(texto, letra)} letras '{letra}' ");
        }

        private static string UserText()
        {
            Console.WriteLine("informe o texto");
            return Console.ReadLine();

        }
    }

}
