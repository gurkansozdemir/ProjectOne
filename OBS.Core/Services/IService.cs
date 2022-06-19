using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Core.Services
{
    public interface IService<T> where T : class
    {
        Task AddAsync(T entity); // Create
        Task<IEnumerable<T>> GetAllAsync(); // Read
        Task<T> GetByIdAsync(int id);
        Task UpdateAsync(T entity); // Update
        Task DeleteAsync(T entity); // Delete
    }
}
