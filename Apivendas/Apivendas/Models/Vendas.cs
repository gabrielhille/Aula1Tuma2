namespace Apivendas.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vendas
    {
        public int Id { get; set; }

        public int Carro { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor { get; set; }

        public bool Ativo { get; set; }

        public int UsuInc { get; set; }

        public int UsuAlt { get; set; }

        public DateTime DatInc { get; set; }

        public DateTime DatAlt { get; set; }

        [JsonIgnore]

        public virtual Carros Carros { get; set; }
    }
}
