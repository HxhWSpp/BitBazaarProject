using AppsApi.Data.Entities;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories.Abstractions
{
    public interface IGenreRepository
    {
        Task<ICollection<Genre>> GetAllAsync();
        Task<ICollection<Genre>> GetAsync(Expression<Func<Genre, bool>> predicate);
        Task<Genre> GetByIdAsync(int id);
        Task AddAsync(Genre entity);
        Task UpdateAsync(Genre entity);
        Task DeleteByIdAsync(int id);

        Task<Genre> GetAppsByGenre(int id);

    }
}
