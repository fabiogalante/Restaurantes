using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantes.Api.Models
{
    public class Restaurante
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public string Nome { get; set; }

        [Required, MaxLength(500)]
        public string Endereco { get; set; }

        public DateTime DataAbertura { get; set; }

        public bool Status { get; set; }

        public TipoCozinha Cozinha { get; set; }
    }
}
