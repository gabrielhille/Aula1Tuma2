using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
   
        

        public class SistemaDeCervejaContext
        {

            public List<Cerveja> listaDeCerveja { get; set; }

            public SistemaDeCervejaContext()
            {
                listaDeCerveja = new List<Cerveja>();



                listaDeCerveja.Add(new Cerveja()

                {
                    Id = 1,
                    Nome = "Colorado",
                    Litros = 0.6,
                    Alcool = 8.5,
                    Valor = 14.5,
                });
                listaDeCerveja.Add(new Cerveja()
                {
                    Id = 2,
                    Nome = "Corona",
                    Litros = 0.355,
                    Alcool = 4.5,
                    Valor = 5.5,
                });
                listaDeCerveja.Add(new Cerveja()
                {
                    Id = 3,
                    Nome = "Skol",
                    Litros = 0.350,
                    Alcool = 4.5,
                    Valor = 1.99,
                });
                listaDeCerveja.Add(new Cerveja()
                {
                    Id = 4,
                    Nome = "Patagonia",
                    Litros = 0.455,
                    Alcool = 4.8,
                    Valor = 5.6,
                });
                listaDeCerveja.Add(new Cerveja()
                {
                    Id = 5,
                    Nome = "Antartica",
                    Litros = 0.6,
                    Alcool = 4.7,
                    Valor = 6.25,
                });





            }
        }  
     
}
