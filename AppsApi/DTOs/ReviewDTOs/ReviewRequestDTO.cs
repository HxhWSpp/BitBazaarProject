using AppsApi.DTOs.Abstractions;

namespace AppsApi.DTOs.ReviewDTOs
{
    public class ReviewRequestDTO : BaseRequestDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Recommended { get; set; }

        public int AppId { get; set; }
        public string? UserId { get; set; }
    }
}
