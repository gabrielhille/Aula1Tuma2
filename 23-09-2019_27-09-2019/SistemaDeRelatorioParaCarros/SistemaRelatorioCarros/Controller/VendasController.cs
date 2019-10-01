using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace SistemaRelatorioCarros.Controller
{
    public class VendasController
    {
        SistemaVendasContext vendasContext = new SistemaVendasContext();
        public List<Venda> GetVendas(int mes = 0)
        {
            //retorna nossa lista de vendas sem nenhum tipo de filtro no momento
            if (mes == 0)
                return vendasContext.ListaVendasPublica;
            else
                return vendasContext.ListaVendasPublica.FindAll(x => x.Data.Month == mes);
        }

    }
}
