using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaDeCervejaContext sistemaDeCervejaContext = new SistemaDeCervejaContext();
        /// <summary>
        /// metodo que retorna lista de cervejas
        /// </summary>
        /// <returns></returns>
        public List<Cerveja> GetCervejas()
        {
            return sistemaDeCervejaContext.listaDeCerveja;
        }


        public double RetornarValor()
        {
           return  sistemaDeCervejaContext.listaDeCerveja.Sum(x => x.Valor);
             
        }
        public double RetornarValorEmLitros()
        {
            return sistemaDeCervejaContext.listaDeCerveja.Sum(x => x.Litros);
             
        }

        public void AdicionarCerveja(Cerveja cerveja)
        {
            var novoId = sistemaDeCervejaContext.listaDeCerveja.Count;
            cerveja.Id = novoId++;

            sistemaDeCervejaContext.listaDeCerveja.Add(cerveja);


        }

            

    }

}
