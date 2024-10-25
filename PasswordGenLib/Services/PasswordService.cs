using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Xml.Linq;

namespace ApplicationCore.Services
{
    public class PasswordService
    {
        public List<Password> Passwords { get; private set; }
        private readonly IRepository<Password> _repository;
        public PasswordService(IRepository<Password> repository)
        {
            _repository = repository;
            Passwords = new List<Password>();
        }

        public async Task SavePasswords()
        {
            if (Passwords != null) 
            {
                await _repository.AddRangeAsync(Passwords);
            }
        }

        public void GenerateNewPassword(string alphabit)
        {
            var id = Guid.NewGuid().ToString();


        }
    }
}
