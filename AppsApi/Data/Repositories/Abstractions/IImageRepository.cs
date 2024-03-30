using AppsApi.Data.Entities;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories.Abstractions
{
    public interface IImageRepository
    {
        Task<ICollection<Image>> GetAllAsync();
        Task<ICollection<Image>> GetAsync(Expression<Func<Image, bool>> predicate);
        Task<Image> GetByIdAsync(int id);
        Task AddAsync(Image entity);
        Task UpdateAsync(Image entity);
        Task<string> DeleteByIdAsync(int id);

    }
}
