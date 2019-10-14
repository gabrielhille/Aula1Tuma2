using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RevisandoEntity.Model
{
    public class CervejaContextDB :
        DbContext //Herdamos nossa classe Dbcontext
    {
        public DbSet<Cerveja> Cervejas { get; set; } //Tabela dentro do banco de dados
    }
}
