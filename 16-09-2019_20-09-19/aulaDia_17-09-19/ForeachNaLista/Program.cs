using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDateTime();
            Console.WriteLine("----------------------------------------------------------------------");
            ListaDeInteiros();
            Console.WriteLine("----------------------------------------------------------------------");
            ListaDeDecimais();
            Console.WriteLine("----------------------------------------------------------------------");
            ListaString();

            Console.ReadKey();
        }

        /// <summary>
        /// Lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));

            minhaLista.ForEach(minhaData => Console.WriteLine($"Lista de datas :{minhaData.ToLongDateString()}"));
            

            

        }

        /// <summary>
        /// Lista de marcas de smartphones
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(i => Console.WriteLine($"marca de smartphones: {i}"));

            

        }

        /// <summary>
        /// Lista de numeros inteiros
        /// </summary>
        private static void ListaDeInteiros()
        {
            var inteiros = new List<int>();
            inteiros.Add(17);
            inteiros.Add(18);
            inteiros.Add(19);
            inteiros.Add(20);

            inteiros.ForEach(i=> Console.WriteLine($"Numeros inteiros: {i}"));

            




        }


        /// <summary>
        /// Lista de numeros decimais
        /// </summary>
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(meuDecimal => Console.WriteLine($"Numero real: {meuDecimal.ToString("C") + " / " + FormataNumeroDecimalEmDolar (meuDecimal) + " / " + FormataNumeroDecimalEmEuro (meuDecimal) + " / "+ FormataNumeroDecimalEmYen(meuDecimal) + " / " + FormataNumeroDecimalEmBitCoin(meuDecimal) } "));
            

        }
        /// <summary>
        /// conversao real / euro
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmDolar (double meuNumero)
        {
            return (meuNumero /4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

        }
        /// <summary>
        /// conversao real / euro
        /// </summary>
        /// <param name="meuNumeroEuro"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmEuro(double meuNumeroEuro)
        {
            
            return (meuNumeroEuro / 4.5298).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$" , "Euro ");

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
                .Replace("$" , "BTC ") ;

        }

    }
}
