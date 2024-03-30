using AppsApi.Data.Entities;
using AppsApi.DTOs.GenreDTOs;
using AutoMapper;

namespace AppsApi.Profiles
{
    public class GenreProfile : Profile
    {
        public GenreProfile()
        {
            CreateMap<Genre, GenreResponseDTO>();
            CreateMap<GenreRequestDTO, Genre>();

            CreateMap<Genre, GenreDetailResponseDTO>();
        }
    }
}
