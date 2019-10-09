using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    //1- Usar nossa pasta model  using CatalogoCelulares.Model;
    //2- criar uma instancia nova da nossa context  CelularesContextDB contextDB = new CelularesContextDB();
    public class CelularesController
    {
        CelularesContextDB contextDB = new CelularesContextDB();

        //Listagem
        /// <summary>
        /// Metodo que retorna nossa lista de celulares ativos apenas
        /// </summary>
        /// <returns>querylist de celulares filtrando por ativo</returns>
        public IQueryable <Celular> GetCelulares()
        {
            return contextDB // acesso ao banco de dados
                .Celulares  //Tabela do banco de dados
                .Where //Indicamos que vamos realizar um filtro
                (x => x.Ativo == true); //As condições do filtro
        }
        
        //Atualização
        /// <summary>
        /// Metodo que autaliza um registro ja validado do nosso sistema
        /// </summary>
        /// <param name="item">Item que vamos atualizar</param>
        /// <returns>retorna verdadeiro caso item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = //Definimos uma variavel para o celular
                contextDB // Usamos o nosso banco de dados
                .Celulares //Nossa tabela que contem os celulares
                .FirstOrDefault //Buscamos a nossa tabela celulare
                (x => x.Id == item.Id); //Regra para realizar a busca

            if (celular == null) //verificamos se ele realmente encontrou uma celular
                return false; //caso nao tenha encontrado retornamos falso
            else
            {
                
                item.DataAlteracao = DateTime.Now;   //atualiza a data da alteração do celular
            }
            contextDB.SaveChanges(); //salvamos as informações do banco de dados

            return true; //retorna que foi atualizado

        }
        
        //Inserção
        /// <summary>
        /// Metodo que valida e isere os registros do sistema
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>retorna verdadeiro para um item validado</returns>
        public bool InserirCelular(Celular item)
        {
            if (string
                .IsNullOrWhiteSpace //Metodo que identifica espaços em branco
                (item.Marca))       //Nosso campo que vamos validar
                return false;

            if (string
                .IsNullOrWhiteSpace  //Metodo que identifica espaços em branco
                (item.Modelo))       //Nosso campo que vamos validar
                return false;


            if (item.Preco <= 0)
                
                return false;

            contextDB.Celulares.Add(item);
            contextDB.SaveChanges();
            return true;
        }
        
        //'Remoção'
        /// <summary>
        /// metodo utilizado para desativar um item dentro do nosso sistema
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retrna verdadeiro em caso de sucesso</returns>
        public bool RemoverCelular(int id)
        {
            var celular = //variavel 
                contextDB //Base de dados
                .Celulares // Tabela celular
                .FirstOrDefault //Buscamos o item para desativar
                (x => x.Id == id); //regra de busca por ID


            if (celular == null) //verifica a existencia do  item
                return false; //caso nao tenha ele sai do nosso metodo


            celular.Ativo = false; //desativamos o item

            contextDB.SaveChanges(); //salvamos as alterações em noss banco de dados

            return true; //retornamos verdadeiro
        }
    }
}
