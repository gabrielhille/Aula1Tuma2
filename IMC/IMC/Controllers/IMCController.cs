using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IMC.Controllers
{
    public class IMCController : ApiController
    {
        public string Get(string nome, double peso, double altura)
        {
            var resultado = (peso / (altura * altura));

            if (resultado <= 21)
            {
                return $"Olá {nome} , você esta usando crack seu IMC é {resultado.ToString("N2")}";

            }
            if (resultado>=25)
            {
                return $"Olá {nome} , você esta acima do peso seu IMC é {resultado.ToString("N2")}";

            }
            else
            {
                return $"Olá {nome} você esta no peso ideal seu IMC é {resultado.ToString("N2")}";
            }
        }
        
    }
}
