namespace WebImobiliaria.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebImobiliaria.Models.Migration>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebImobiliaria.Models.Migration";
        }

        protected override void Seed(WebImobiliaria.Models.Migration context)
        {
            context.Proprietarios.AddOrUpdate(x => x.Nome, new Models.Proprietario()
            {
                Nome = "Gabriel",
                DataNas = DateTime.Parse("24/07/1990"),
                Email = "gabrielhille1990@gmail.com"

            });
            context.SaveChanges();
            var proprietarioId = context.Proprietarios.FirstOrDefault(x => x.Nome == "Gabriel").Id;

            context.Imoveis.AddOrUpdate(x => x.ProprietarioId, new Models.Imovel()
            {
                ProprietarioId = proprietarioId,
                Logradouro = "Rua Emil Hornburg",
                Bairro = "Testo Alto",
                Cep = "89107000",
                Complemento = "Casa",
                Municipio = "Pomerode",
                Numero = 36


            }) ;
            context.SaveChanges();
        }
    }
}
