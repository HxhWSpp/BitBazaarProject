using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories
{
    public class DeveloperRepository : IDeveloperRepository
    {
        public readonly AppDbContext _context;
        private readonly DbSet<Developer> _dbSet;
        public DeveloperRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Developer>();
        }
        public async Task AddAsync(Developer entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"Item does not exist! (ID: {id}");
            }
        }

        public async Task<ICollection<Developer>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Developer> GetAppsByDeveloper(int id)
        {
            var entity = await _dbSet.Include(a => a.Apps).SingleOrDefaultAsync(a => a.Id == id);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                throw new InvalidOperationException($"Item does not exist! (ID: {id}");
            }
        }

        public async Task<ICollection<Developer>> GetAsync(Expression<Func<Developer, bool>> predicate)
        {
            return await _dbSet.Where(predicate).Include(i => i.Apps).ToListAsync();
        }

        public async Task<Developer> GetByIdAsync(int id)
        {
            if (id > 0)
            {
                var entity = await _dbSet.Include(i => i.Apps).SingleOrDefaultAsync(a => a.Id == id);
                if (entity != null)
                {
                    return entity;
                }
                else
                {
                    throw new InvalidOperationException($"Item not found!");
                }
            }
            else
            {
                throw new InvalidOperationException($"Id must be bigger than {id}!");
            }
        }

        public async Task UpdateAsync(Developer entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
