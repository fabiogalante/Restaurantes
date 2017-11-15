using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurantes.Api.Models;
using Restaurantes.Api.Services;
using Restaurantes.Api.ViewModels;

namespace Restaurantes.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Restaurante")]
    public class RestauranteController : Controller
    {
        private readonly IRestauranteData _restauranteData;

        public RestauranteController(IRestauranteData restauranteData)
        {
            _restauranteData = restauranteData;

        }

        public IActionResult Get()
        {
            var restaurantes = _restauranteData.GetAll();
            return Ok(restaurantes);
        }

        [HttpGet("{id}", Name = "ObterRestaurantes")]
        public IActionResult Get(int id)
        {
            var restaurante = _restauranteData.Get(id);

            if (restaurante == null)
                return NotFound();

            return Ok(restaurante);
        }


        [HttpPost]
        public IActionResult Create([FromBody] Restaurante restaurante)
        {

            if (restaurante == null)
            {
                return BadRequest();
            }

            restaurante =  _restauranteData.Add(restaurante);

            return CreatedAtRoute("ObterRestaurantes", new {id = restaurante.Id}, restaurante);

        }
    }
}