using System.ComponentModel.DataAnnotations;

namespace AppsApi.DTOs.UserDTOs
{
    public class UserRegisterDTO
    {
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(6)]
        public string Password { get; set; }
        public string Description { get; set; }
        public string? ProfilePicture { get; set; }
        public IFormFile ProfileFile { get; set; }
        public string UserName { get; set; }
    }
}
