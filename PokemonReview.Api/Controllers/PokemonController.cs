using Microsoft.AspNetCore.Mvc;
using PokemonReview.Api.Interfaces;
using PokemonReview.Api.Models;

namespace PokemonReview.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemnRepository;

        public PokemonController(IPokemonRepository pokemnRepository)
        {
            _pokemnRepository = pokemnRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type=typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons()
        {
           var pokemons  = _pokemnRepository.GetPokemons();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }        
           
           return Ok(pokemons);
        }
    }
}
