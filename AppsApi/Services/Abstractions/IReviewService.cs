using AppsApi.DTOs.GenreDTOs;
using AppsApi.DTOs.ReviewDTOs;

namespace AppsApi.Services.Abstractions
{
    public interface IReviewService
    {
        Task<ICollection<ReviewResponseDTO>> GetReviewsAsync();
        Task<ReviewResponseDTO> GetReviewByIdAsync(int id);
        Task<ReviewResponseDTO> GetReviewByNameAsync(string name);
        Task AddReviewAsync(ReviewRequestDTO review);
        Task DeleteReviewByIdAsync(int id);
        Task UpdateReviewAsync(ReviewRequestDTO review);

        Task<ICollection<ReviewResponseDTO>> GetReviewsOfApp(int appId);
    }
}
