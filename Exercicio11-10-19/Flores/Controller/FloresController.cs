using FloresController.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace FloresController.Controller
{
    public class FloresController
    {
        FloresContextDB  contextDB = new FloresContextDB();


        public bool CadastrarFlor(Model.Flores item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))

                return false;

            contextDB.nome.Add(item);
            contextDB.SaveChanges();

            return true;
            
        }

        public IQueryable<Flores> GetFlores()
        {
            return contextDB.nome.Where(x => x.Ativo == true);
         
        }

    }
}
