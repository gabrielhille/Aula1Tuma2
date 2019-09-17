using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Sistema conversor de moedas cabuloso---");
            Console.WriteLine("Informe um valor a ser convertido: ");

            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão");
            Console.WriteLine("DOLAR,EURO,YEN, BTC");

            var moedaAlvoParaConverter = Console.ReadLine();

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);


            Console.ReadKey();


        }
        /// <summary>
        /// Parametro para decidir qual a moeda que ira ser convertida
        /// </summary>
        /// <param name="minhaMoeda">Moeda em valor real</param>
        /// <param name="moedaAlvo">Alvo em que a moeda sera convertida</param>
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {
           
            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataNumeroDecimalEmEuro(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormataNumeroDecimalEmYen(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormataNumeroDecimalEmBitCoin(minhaMoeda));
                    break;

                default:
                    break;
            }


        }
       
        /// <summary>
        /// conversao real / dolar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

        }
       
        /// <summary>
        /// conversao real / euro
        /// </summary>
        /// <param name="meuNumeroEuro"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmEuro(double meuNumeroEuro)
        {

            return (meuNumeroEuro / 4.5298).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$", "Euro ");

        }

        /// <summary>
        /// conversão real/yen
        /// </summary>
        /// <param name="meuNumeroYen"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmYen(double meuNumeroYen)
        {
            return (meuNumeroYen / 0.038).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));

        }

        /// <summary>
        /// conversao para bitcoin
        /// </summary>
        /// <param name="meuNumeroBitCoin"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmBitCoin(double meuNumeroBitCoin)
        {
            return (meuNumeroBitCoin / 41793.90).ToString("C6", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$", "BTC ");

        }
    }

}
