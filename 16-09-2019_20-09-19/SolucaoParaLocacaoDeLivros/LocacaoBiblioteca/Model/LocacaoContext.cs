using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext :DbContext
    { 
    
        public  DbSet<LivrosNew> Livros { get; set; } 
        public  DbSet<UserNews> Usuarios { get; set; } 
 

    }
}

