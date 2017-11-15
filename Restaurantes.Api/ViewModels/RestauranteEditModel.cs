using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Restaurantes.Api.Models;

namespace Restaurantes.Api.ViewModels
{
    public class RestauranteEditModel
    {
        public string Nome { get; set; }
        public TipoCozinha Cozinha { get; set; }

        
    }
}
