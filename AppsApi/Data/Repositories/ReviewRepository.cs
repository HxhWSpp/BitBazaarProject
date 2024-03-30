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
        public async Task AddAsync(Review entity)
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

        public async Task<ICollection<Review>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<ICollection<Review>> GetAsync(Expression<Func<Review, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
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

        public async Task UpdateAsync(Review entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
