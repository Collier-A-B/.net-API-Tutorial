using PokemonReviewApp.models;

namespace PokemonReviewApp.Interface
{
    public interface ICategoryRepository
    {
        /**
         * Get Requests
         * 
         * Handles Read-Only https requests
         */
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int id);
        /**
         * Post Requests
         * 
         * Handles Insertion to database https requests
         */
        bool CreateCategory(Category category);
        bool Save();

    }
}
