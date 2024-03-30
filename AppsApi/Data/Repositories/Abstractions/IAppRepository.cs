using AppsApi.Data.Entities;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories.Abstractions
{
    public interface IAppRepository
    {
        Task<ICollection<App>> GetAllAsync();
        Task<ICollection<App>> GetAsync(Expression<Func<App, bool>> predicate);
        Task<App> GetByIdAsync(int id);
        Task AddAsync(App entity);
        Task UpdateAsync(App entity);
        Task DeleteByIdAsync(int id);
    }
}
