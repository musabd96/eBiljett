using eBiljett.Models;

namespace eBiljett.Data.Base
{
    public interface IEntityBaseRepo<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);

        Task AddAsync(T entity);
        Task UpdateAsync(int Id, T entity);
        Task DeleteAsync(int Id);
    }
}
