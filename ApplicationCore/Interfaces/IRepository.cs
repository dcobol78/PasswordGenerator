using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetPasswordsAsync();

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        Task SaveAsyync();
    }
}
