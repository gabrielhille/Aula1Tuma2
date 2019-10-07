﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB :
        DbContext // DbContext classe pronta que contem todo o proceso de conexão com o banco de dados listagem das tabelas 
        //seleção das informações

    {
        public DbSet//Palavra reservada para o Entity que indica que vamos definir uma tabela do nosso banco de dados 
            <Pessoa>//Aqui definimos nossa tabela pessoa ou seja especificamos qual de nossas classe sera uma referencia de uma
            //tabela no banco de dados ela vai ao banco com o nome que definimos em nossa classe
            listaDePessoas { get; set; } // nesta pare liberamos nossa tabela para acessar
    }
}
