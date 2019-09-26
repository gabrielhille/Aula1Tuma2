using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaDeCarrosContext
    {
        public List<Carro> listaDeCarros { get; set; }
     
        
        public SistemaDeCarrosContext()
        {
            listaDeCarros = new List<Carro>();

            listaDeCarros.Add(new Carro()
            {
                Id = 1,
                Marca = "Ford",
                Modelo = "Focus",
                Ano = 2010,
                Cilindradas = 2000,
                Portas = 4
            });
            listaDeCarros.Add(new Carro()
            {
                Id = 2,
                Marca = "Volkswagen",
                Modelo = "Fox",
                Ano = 2016,
                Cilindradas = 1600,
                Portas = 4
            });
            listaDeCarros.Add(new Carro()
            {
                Id = 3,
                Marca = "Fiat",
                Modelo = "Argo",
                Ano = 2018,
                Cilindradas = 1300,
                Portas = 4
            });
            listaDeCarros.Add(new Carro()
            {
                Id = 4,
                Marca = "Kia",
                Modelo = "Cerato",
                Ano = 2015,
                Cilindradas = 1600,
                Portas = 4
            });
            listaDeCarros.Add(new Carro()
            {
                Id = 5,
                Marca = "Ford",
                Modelo = "Ka",
                Ano = 2019,
                Cilindradas = 1000,
                Portas = 4
            });
            listaDeCarros.Add(new Carro()
            {
                Id = 6,
                Marca = "Chevrolet",
                Modelo = "Astra",
                Ano = 1999,
                Cilindradas = 1800,
                Portas = 2
            });
            listaDeCarros.Add(new Carro()
            {
                Id = 7,
                Marca = "Fiat",
                Modelo = "Marea",
                Ano = 2001,
                Cilindradas = 2400,
                Portas = 4
            });
            listaDeCarros.Add(new Carro()
            {
                Id = 8,
                Marca = "Honda",
                Modelo = "Civic",
                Ano = 2009,
                Cilindradas = 1800,
                Portas = 4
            });
            listaDeCarros.Add(new Carro()
            {
                Id = 9,
                Marca = "Chevrolet",
                Modelo = "Montana",
                Ano = 2014,
                Cilindradas = 1400,
                Portas = 4
            });
            listaDeCarros.Add(new Carro()
            {
                Id = 10,
                Marca = "Chevrolet",
                Modelo = "Opala",
                Ano = 1989,
                Cilindradas = 4100,
                Portas = 4
            });
        }
    }

    
}
