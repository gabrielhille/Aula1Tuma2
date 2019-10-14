using ListagemDeNomes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 


namespace ListagemDeNomes.Controller
{
    public class ListagemController
    {
        ListagemcontextDb contextDB = new ListagemcontextDb();


        public bool AdicionarNome(Nomes parametroNome)
        {
            if (string.IsNullOrWhiteSpace(parametroNome.Nome))
                return false;
            contextDB.nomes.Add(parametroNome);
            contextDB.SaveChanges();
            return true;
        }

        public IQueryable<Nomes> RetornaListaDeNomes()
        {
            return contextDB.nomes.Where(x => x.Ativo == true);
        }
    }
    
}
