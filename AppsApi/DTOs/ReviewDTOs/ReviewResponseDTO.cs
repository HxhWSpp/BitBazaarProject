using AppsApi.DTOs.Abstractions;
using AppsApi.DTOs.AppDTOs;

namespace AppsApi.DTOs.ReviewDTOs
{
    public class ReviewResponseDTO : BaseResponseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Recommended { get; set; }

        //public AppResponseDTO App { get; set; }
    }
}
