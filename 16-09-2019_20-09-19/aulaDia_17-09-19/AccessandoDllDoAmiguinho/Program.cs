using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AccessandoDllDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {

            var dllDoAmiguinho = new MinhaBiBlioteca.CalculosDeArea();
            Console.WriteLine(dllDoAmiguinho.CalculaAreaDoQuadrado(9));



            Console.ReadKey();
        }
    }
}
