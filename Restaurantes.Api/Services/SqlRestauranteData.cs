using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Restaurantes.Api.Data;
using Restaurantes.Api.Models;

namespace Restaurantes.Api.Services
{
    public class SqlRestauranteData : IRestauranteData
    {
        private readonly RestauranteDbContext _context;

        public SqlRestauranteData(RestauranteDbContext context)
        {
            _context = context;
        }


        public Restaurante Add(Restaurante restaurant)
        {
            _context.Restaurantes.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurante Get(int id)
        {
            return _context.Restaurantes.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurante> GetAll()
        {
            return _context.Restaurantes.OrderBy(r => r.Nome);
        }

        public Restaurante Update(Restaurante restaurant)
        {
            _context.Attach(restaurant).State =
                EntityState.Modified;
            _context.SaveChanges();
            return restaurant;
        }
    }
}
