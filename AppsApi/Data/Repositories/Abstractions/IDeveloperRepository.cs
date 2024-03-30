using AppsApi.Data.Entities;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories.Abstractions
{
    public interface IDeveloperRepository
    {
        Task<ICollection<Developer>> GetAllAsync();
        Task<ICollection<Developer>> GetAsync(Expression<Func<Developer, bool>> predicate);
        Task<Developer> GetByIdAsync(int id);
        Task AddAsync(Developer entity);
        Task UpdateAsync(Developer entity);
        Task DeleteByIdAsync(int id);

        Task<Developer> GetAppsByDeveloper(int id);
    }
}
