using Domain.Entities.Common;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity:BaseEntity
    {
        private readonly ResumeDbContext _Context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ResumeDbContext context)
        {
            _Context = context;
             this._dbSet = _Context.Set<TEntity>();
        }


        public IQueryable<TEntity> GetQuery()
        {
           return _dbSet.AsQueryable();
        }




        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }


        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Id == id);
        }


        public async Task AddAsync(TEntity entity)
        {
           await _dbSet.AddAsync(entity);
        }


        public async Task UpdateAsync(TEntity entity)
        {
            entity.UpdateDate = DateTime.Now;
            _dbSet.Update(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            entity.IsDelete = true;
            entity.DeleteDate = DateTime.Now;
            await UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            TEntity entity = await GetByIdAsync(id);
            await DeleteAsync(entity); 
        
        }

    
        public async Task SaveAsync()
        {
           await _Context.SaveChangesAsync();
        }

        
    }
}
