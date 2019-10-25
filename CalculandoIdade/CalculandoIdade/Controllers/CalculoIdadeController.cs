using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    /// <summary>
    /// Retornar nome da aplicação e o que ela faz
    /// </summary>
    public class CalculoIdadeController : ApiController
    {
        public string Get()
        {
            return "App para poder beber hoje";
        }
        public string Get(int anoNascimento, string nomeUsuario = "Default")
        {
            if ((DateTime.Now.Year - anoNascimento) > 18)
            {
                return $"Ola {nomeUsuario} De acordo com os calculos realizados em nosso servidor "
                    + " Bora toma uma"
                    + " E o gole";
            }
            else
            {
                return "Cheiro de leite "
                    + "Vaza, bora toma agua";
            }
        }

    }
}
