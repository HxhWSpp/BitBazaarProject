using AppsApi.Data.Entities;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories.Abstractions
{
    public interface IReviewRepository : IRepository<Review>
    {
        Task<Review> GetReviewDetailsByIdAsync(int id);
    }
}
