using AppsApi.Data.Entities;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories.Abstractions
{
    public interface IAppRepository : IRepository<App>
    {
        Task<App> GetAppDetailsByIdAsync(int id);
    }
}
