using AppsApi.Data.Entities;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.Profiles.Abstractions;
using AutoMapper;

namespace AppsApi.Profiles
{
    public class GenreProfile : BaseProfile
    {
        public GenreProfile()
        {
            CreateMap<Genre, GenreResponseDTO>();
            CreateMap<GenreRequestDTO, Genre>();

            CreateMap<Genre, GenreDetailResponseDTO>();
        }
    }
}
