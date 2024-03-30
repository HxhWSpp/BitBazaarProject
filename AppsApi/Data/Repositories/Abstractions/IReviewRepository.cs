using AppsApi.Data.Entities;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories.Abstractions
{
    public interface IReviewRepository
    {
        Task<ICollection<Review>> GetAllAsync();
        Task<ICollection<Review>> GetAsync(Expression<Func<Review, bool>> predicate);
        Task<Review> GetByIdAsync(int id);
        Task AddAsync(Review entity);
        Task UpdateAsync(Review entity);
        Task DeleteByIdAsync(int id);
    }
}
