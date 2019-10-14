using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        EntityContextDB contextDB = new EntityContextDB();



        public 
            IQueryable //Aqui temos a nossa primeira Interface com a classe Iqueryable essa classe contem varias funcionalidades prontas
                       //para usar igual ao banco de dados como os selects.
            <Pessoa>  //Definimos o tipo que ira retornar
             GetPessoas() //Damos um nome ao nosso metodo
        {
            return contextDB.listaDePessoas; //retornamos nossa lista de pessoas
        }

        public void AddPessoa (Pessoa item)
        {
          


            contextDB // Nosso banco de dados
                .listaDePessoas //nossa tabela de pessoas
                .Add(item);//Adicionamos o item

            contextDB.SaveChanges(); //salvamos no banco de dados 
        }
    }
}
