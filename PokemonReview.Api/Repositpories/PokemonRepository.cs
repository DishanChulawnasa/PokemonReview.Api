using PokemonReview.Api.Data;
using PokemonReview.Api.Interfaces;
using PokemonReview.Api.Models;

namespace PokemonReview.Api.Repositpories
{
    public class PokemonRepository: IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }
    }
}
