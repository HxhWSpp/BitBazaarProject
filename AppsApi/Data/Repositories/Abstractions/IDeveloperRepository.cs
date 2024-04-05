using AppsApi.Data.Entities;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories.Abstractions
{
    public interface IDeveloperRepository : IRepository<Developer>
    {        
        Task<Developer> GetDeveloperDetailsByIdAsync(int id);
    }
}
