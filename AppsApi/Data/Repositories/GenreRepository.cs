using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        public readonly AppDbContext _context;
        private readonly DbSet<Genre> _dbSet;
        public GenreRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Genre>();
        }
        public async Task AddAsync(Genre entity)
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

        public async Task<ICollection<Genre>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Genre> GetAppsByGenre(int id)
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

        public async Task<ICollection<Genre>> GetAsync(Expression<Func<Genre, bool>> predicate)
        {
            return await _dbSet.Where(predicate).Include(a => a.Apps).ToListAsync();
        }

        public async Task<Genre> GetByIdAsync(int id)
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

        public async Task UpdateAsync(Genre entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
