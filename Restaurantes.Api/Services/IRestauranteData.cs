using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurantes.Api.Models;

namespace Restaurantes.Api.Services
{
    public interface IRestauranteData
    {
        IEnumerable<Restaurante> GetAll();
        Restaurante Get(int id);
        Restaurante Add(Restaurante restaurant);
        Restaurante Update(Restaurante restaurant);
    }
}
