using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike.Model
{
   public  class BikesContextDB : DbContext
    {
        public DbSet<ListaDeBikes> ListaDeBikes { get; set; }
    }
}
// public DbSet<Usuario> Usuarios { get; set; } 