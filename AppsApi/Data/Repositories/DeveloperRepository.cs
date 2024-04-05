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
        public async Task<bool> AddAsync(Developer entity)
        {
            await _dbSet.AddAsync(entity);
            if (await _context.SaveChangesAsync() <= 0)
            {
                throw new Exception("Something went wrong while adding the entity!");
            }
            else
            {
                return true;
            }
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                if (await _context.SaveChangesAsync() <= 0)
                {
                    throw new Exception("Something went wrong while deleting the entity!");
                }
                else
                {
                    return true;
                }
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

        public async Task<Developer> GetDeveloperDetailsByIdAsync(int id)
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
                var entity = await _dbSet.SingleOrDefaultAsync(a => a.Id == id);
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

        public async Task<bool> UpdateAsync(Developer entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.Update(entity);
            if (await _context.SaveChangesAsync() <= 0)
            {
                throw new Exception("Something went wrong while updating the entity!");
            }
            else
            {
                return true;
            }
        }
    }
}
