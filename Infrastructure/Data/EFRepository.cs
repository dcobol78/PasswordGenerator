using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class EFRepository: IRepository<Password>
    {
        private readonly PasswordContext _dbContext;
        public EFRepository(PasswordContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Password>> GetPasswordsAsync()
        {
            var allPasswords = await _dbContext.Passwords.ToListAsync();
            
            return allPasswords;
        }

        public async Task SaveAsyync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddAsync(Password entity)
        {
            await _dbContext.Passwords.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Password> entities)
        {
            await _dbContext.Passwords.AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
        }
    }
}
