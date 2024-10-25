using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Data
{
    public class EFRepository<T>: IRepository<T> where T : class
    {
        public EFRepository(PasswordContext dbContext) 
        { }

        public Task<IEnumerable<T>> GetPasswordsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.AddRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
