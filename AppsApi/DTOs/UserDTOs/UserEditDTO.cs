namespace AppsApi.DTOs.UserDTOs
{
    public class UserEditDTO
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string ProfilePicture { get; set; }
        public IFormFile? ProfileFile { get; set; }
        public string UserName { get; set; }
    }
}
