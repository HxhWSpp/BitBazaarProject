using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories
{
    public class ImageRepository : IImageRepository
    {
        public readonly AppDbContext _context;
        private readonly DbSet<Image> _dbSet;
        public ImageRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Image>();
        }
        public async Task<bool> AddAsync(Image entity)
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

        public Task<ICollection<Image>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Image>> GetAsync(Expression<Func<Image, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<Image> GetByIdAsync(int id)
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

        public Task<bool> UpdateAsync(Image entity)
        {
            throw new NotImplementedException();
        }
               
    }
}
