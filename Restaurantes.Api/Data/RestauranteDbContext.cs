using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurantes.Api.Models;

namespace Restaurantes.Api.Data
{
    public class RestauranteDbContext : DbContext
    {
        public RestauranteDbContext(DbContextOptions options)
            : base(options) 
        {

        }

        public DbSet<Restaurante> Restaurantes { get; set; }
    }
}
