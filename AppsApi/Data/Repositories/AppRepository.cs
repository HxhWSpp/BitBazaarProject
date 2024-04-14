using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using AppsApi.DTOs.Paginaton;
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
        public async Task<bool> AddAsync(App entity)
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
                    throw new Exception("Something went wrong while removing the entity!");
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

        public async Task<ICollection<App>> GetAllAsync(PaginationQuery paginationQuery)
        {
            if (paginationQuery == null)
            {
                return await _dbSet.Include(i => i.Images).ToListAsync();
            }
            var skip = (paginationQuery.PageNumber - 1) * paginationQuery.PageSize;
            return await _dbSet.Include(i => i.Images).Skip(skip).Take(paginationQuery.PageSize).ToListAsync();
        }

        public async Task<App> GetAppDetailsByIdAsync(int id)
        {
            var entity = await _dbSet.Include(i => i.Images).Include(g => g.Genres).Include(d => d.Developer).Include(r => r.Reviews).AsSplitQuery().SingleOrDefaultAsync(a => a.Id == id);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                throw new InvalidOperationException($"Item does not exist! (ID: {id}");
            }
        }


        public async Task<ICollection<App>> GetAsync(Expression<Func<App, bool>> predicate)
        {
            return await _dbSet.Where(predicate).Include(i => i.Images).Include(g => g.Genres).Include(d => d.Developer).Include(r => r.Reviews).AsSplitQuery().ToListAsync();
        }

        public async Task<App> GetByIdAsync(int id)
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

        public async Task<bool> UpdateAsync(App entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.Update(entity);
            if (await _context.SaveChangesAsync() <= 0)
            {
                throw new Exception("Something went wrong while upading the entity");
            }
            else
            {
                return true;
            }

        }
    }
}
