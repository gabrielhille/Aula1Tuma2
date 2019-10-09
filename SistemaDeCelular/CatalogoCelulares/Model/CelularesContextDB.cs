using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class CelularesContextDB : DbContext //definomos a herança
    {
        public DbSet<Usuario> Usuarios { get; set; } //define a primeira tabela do banco de dados
        public DbSet<Celular> Celulares { get; set; } //define tabela celulares
    }
}
