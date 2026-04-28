

using Domain.Entities.Common;

namespace Infrastructure.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetQuery();


        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync (int id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task SaveAsync();

    }
}
