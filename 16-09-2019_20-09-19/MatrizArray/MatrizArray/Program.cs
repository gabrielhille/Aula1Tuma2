using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLinear = new string[2];
            arrayLinear[0] = "felipe";
            arrayLinear[1] = "carlo";
            List<string> listaLinear = new List<string>
            {
                "felipe",
                "giomar" ,
                "marcio",


            };

            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(listaLinear[0]);
            Console.ReadKey();



            

        }
    }
}
