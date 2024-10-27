using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IPasswordService
    {
        public void GeneratePassword(IAlphabitComponent alphabit, int length, string uniqueSymbols = "");
        public void GenerateSomePasswords(IAlphabitComponent alphabit, int length, int amount);
        public void ClearBuffer();
        public Task<IEnumerable<Password>> GetSavedPasswordsAsync();
        public Task SavePasswords();
        public List<Password> Passwords { get; }
    }
}
