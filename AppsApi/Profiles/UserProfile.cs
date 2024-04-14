using AppsApi.Data.Entities;
using AppsApi.DTOs.ReviewDTOs;
using AppsApi.DTOs.UserDTOs;
using AutoMapper;

namespace AppsApi.Profiles

{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserResponseDTO>();
            CreateMap<User, UserDetailResponseDTO>();

            CreateMap<UserRegisterDTO, User>();
            CreateMap<UserEditDTO, User>();
        }
    }
}
