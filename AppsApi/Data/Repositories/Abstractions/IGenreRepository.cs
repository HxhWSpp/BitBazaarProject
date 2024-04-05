using AppsApi.Data.Entities;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories.Abstractions
{
    public interface IGenreRepository : IRepository<Genre>
    {     
        Task<Genre> GetGenreDetailsByIdAsync(int id);

    }
}
