using PokemonReview.Api.Models;

namespace PokemonReview.Api.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons(); 
    }
}
