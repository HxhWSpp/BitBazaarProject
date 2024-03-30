using AppsApi.Data.Entities;
using AppsApi.DTOs.ReviewDTOs;
using AppsApi.Profiles.Abstractions;

namespace AppsApi.Profiles
{
    public class ReviewProfile : BaseProfile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewResponseDTO>();
            CreateMap<ReviewRequestDTO, Review>();
        }
    }
}
