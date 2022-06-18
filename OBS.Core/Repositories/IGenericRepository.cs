using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity); // Create
        IQueryable<T> GetAll(); // Read
        Task<T> GetByIdAsync(int id);
        void Update(T entity); // Update
        void Delete(T entity); // Delete
    }
}
