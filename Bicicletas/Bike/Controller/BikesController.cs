using Bike.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike.Controller
{
   public  class BikesController
    {
        BikesContextDB contextDB = new BikesContextDB();


        public IQueryable<ListaDeBikes> GetListaDeBikes()
        {
            return contextDB.ListaDeBikes.Where(x => x.Ativo == true);
        }

        public bool AtualizarBike(ListaDeBikes item)
        {
            var bicicleta = contextDB.ListaDeBikes.FirstOrDefault(x => x.Id == item.Id);
            if (bicicleta == null)
                return false;
            else
                item.DataAlteracao = DateTime.Now;

            contextDB.SaveChanges();
            return true;
        }

        public bool InserirBike (ListaDeBikes item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;
            if (item.Valor <= 0)
                return false;
            contextDB.ListaDeBikes.Add(item);
            contextDB.SaveChanges();
            return true;
        }

        public bool RemoverBike(int id)
        {
            var bicicleta = contextDB.ListaDeBikes.FirstOrDefault(x => x.Id == id);
            if (bicicleta == null)
                return false;
            bicicleta.Ativo = false;
            contextDB.SaveChanges();
                return true;
        }
    }
}

