using PokemonReviewApp.models;

namespace PokemonReviewApp.Interface
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
