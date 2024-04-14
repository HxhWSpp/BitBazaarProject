using AppsApi.DTOs.ReviewDTOs;

namespace AppsApi.DTOs.UserDTOs
{
    public class UserDetailResponseDTO : UserResponseDTO
    {
        public  ICollection<ReviewResponseDTO> Reviews { get; set; }
    }
}
