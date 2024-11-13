using PokemonReviewApp.models;

namespace PokemonReviewApp.Interface
{
    public interface ICountryRepository
    {
        /**
         * Get Requests
         *
         * Handles Read-Only operations
         */
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwneersFromCountry(int countryId);
        bool CountryExists(int id);

        /**
         * Post Requests
         * 
         * Handles Create operations
         */

        bool CreateCountry(Country country);
        bool Save();
    }
}
