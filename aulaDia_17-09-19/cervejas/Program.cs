using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cervejas
{
    class Program
    {
        static void Main(string[] args)
        {

            var minhaCerva = new List<string>();

            minhaCerva.Add("SKOL");
            minhaCerva.Add("BRAHMA ");
            minhaCerva.Add("ANTARTICA");
            minhaCerva.Add("LEFFE");
            minhaCerva.Add("POLAR");
            minhaCerva.Add("BOHEMIA");
            minhaCerva.Add("BUDWEISER");
            minhaCerva.Add("CORONA");
            minhaCerva.Add("PATAGONIA");
            minhaCerva.Add("COLORADO");

            minhaCerva.ForEach(i => Console.WriteLine($"As cervejas listadas são: {i}"));

            Console.ReadKey();
        }
    }
}
