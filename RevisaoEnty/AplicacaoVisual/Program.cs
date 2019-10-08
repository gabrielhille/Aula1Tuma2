using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisandoEntity.Model;
using RevisandoEntity.Controller;

namespace AplicacaoVisual
{
    class Program
    {
        //1- Setar a plicação para startar o preject
        //2- vamos adicionar EntityFrameWork ao nosso projeto console
        //3- colocar em nosso ussing o using System.Data.Entity;
        //4- Adicionar a referencia da nossa classLibrary
        static CervejaController cerveja = new CervejaController();
        //static CervejaContextDB cerveja = new CervejaContextDB();
        static void Main(string[] args)
        {
            //cerveja.Cervejas.Add(new Cerveja() { Nome = "oRIGINAL" });
            //cerveja.SaveChanges();

            // cerveja.Cervejas.ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));

            cerveja.AddCerveja(new Cerveja() { Nome = "Cerveja skol" });

            cerveja.GetCervejas()
                .ToList<Cerveja>()
                .ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}
