using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeNomes.Model
{
    public class ListagemcontextDb : DbContext
    {
      
        public DbSet<Nomes> nomes { get; set; }

       
    }
}
