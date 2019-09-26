using ListagemDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Controller
{
     public class CarroController
    {
        SistemaDeCarrosContext sistemaCarroContext = new SistemaDeCarrosContext();


        public List<Carro> GetCarros()
        {
            return sistemaCarroContext.listaDeCarros;
        }

    }
}
