using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories
{
    public class AppRepository : IAppRepository
    {
        public readonly AppDbContext _context;
        private readonly DbSet<App> _dbSet;
        public AppRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<App>();
        }
        public async Task AddAsync(App entity)
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

        public async Task<ICollection<App>> GetAllAsync()
        {
            return await _dbSet.Include(i => i.Images).AsSplitQuery().ToListAsync();
        }

        public async Task<ICollection<App>> GetAsync(Expression<Func<App, bool>> predicate)
        {
            return await _dbSet.Where(predicate).Include(i => i.Images).Include(g => g.Genres).AsSplitQuery().ToListAsync();
        }

        public async Task<App> GetByIdAsync(int id)
        {
            if (id > 0)
            {              
                var entity = await _dbSet.Include(i => i.Images).Include(g => g.Genres).Include(r => r.Reviews).Include(d => d.Developer).AsSplitQuery().SingleOrDefaultAsync(a => a.Id == id);
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

        public async Task UpdateAsync(App entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
