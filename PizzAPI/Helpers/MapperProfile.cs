using AutoMapper;
using PizzAPI.DTOs;
using PizzAPI.models;

namespace PizzAPI.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Pizza, PizzaDTO>().ReverseMap();
            CreateMap<Ingredient, IngredientDTO>().ReverseMap();
            CreateMap<Utilisateur, UtilisateurDTO>().ReverseMap();
        }

    }
}
