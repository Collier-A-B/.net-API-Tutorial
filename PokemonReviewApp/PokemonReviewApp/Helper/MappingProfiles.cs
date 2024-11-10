using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Pokemon, PokemonDto>();
        }

        
    }
}
