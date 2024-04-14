using AppsApi.DTOs.AppDTOs;

namespace AppsApi.DTOs.UserDTOs
{
    public class UserResponseDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public string ProfilePicture { get; set; }
        public double Wallet { get; set; }
        public ICollection<AppResponseDTO> AppsLibrary { get; set; }
        public ICollection<AppResponseDTO> AppsWishlist { get; set; }
    }
}
