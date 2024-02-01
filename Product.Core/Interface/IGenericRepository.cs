using System.Linq.Expressions;

namespace Product.Core.Interface
{
    public interface IGenericRepository <T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, bool>>[] include);
        IEnumerable<T> GetAll(params Expression<Func<T, bool>>[] includes);
        Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes);
        Task<T> GetAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T id, T entity);
        Task DeleteAsync(int id);
    }
}
