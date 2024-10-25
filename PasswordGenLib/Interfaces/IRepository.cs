using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetPasswordsAsync(int id);

        Task AddAsync(T entity);

        Task AddRange(IEnumerable<T> entities);

        Task Save();
    }
}
