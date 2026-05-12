

using Domain.Entities.Common;

namespace Application.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetQuery();


        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?>GetByIdAsync (Guid id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(Guid id);
        Task SaveChangesAsync();

    }
}
