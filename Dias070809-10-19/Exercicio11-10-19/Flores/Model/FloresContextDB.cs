using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloresController.Model
{
    public class FloresContextDB : DbContext
    {
        public DbSet<Flores> nome { get; set; }
    }
}
