using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AppsApi.Data.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Review> _dbSet;
        public ReviewRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Review>();
        }
        public async Task<bool> AddAsync(Review entity)
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

        public async Task<ICollection<Review>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<ICollection<Review>> GetAsync(Expression<Func<Review, bool>> predicate)
        {
            return await _dbSet.Where(predicate).Include(a => a.App).ToListAsync();
        }

        public async Task<Review> GetByIdAsync(int id)
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

        public async Task<bool> UpdateAsync(Review entity)
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
