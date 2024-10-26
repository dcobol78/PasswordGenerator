using ApplicationCore.Alphabit;
using ApplicationCore.Constants;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Text;
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
            Passwords = new();
        }

        public async Task SavePasswords()
        {
            if (Passwords != null) 
            {
                await _repository.AddRangeAsync(Passwords);
            }
        }

        public void GeneratePassword(IAlphabitComponent alphabit, int length)
        {

            if (length <= 0) throw new ArgumentOutOfRangeException(nameof(length));
            if (alphabit == null) throw new ArgumentNullException(nameof(alphabit));

            string uniqueSymbols = new string(alphabit.GetAlhapit().Distinct().ToArray());

            var PasswordId = Guid.NewGuid().ToString();
            var stringBuilderString = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < length; i++) 
            {
                var randomIndex = random.Next(0, uniqueSymbols.Length);
                stringBuilderString.Append(uniqueSymbols[randomIndex]);
            }

            if (Passwords == null) Passwords = new();
            
            Passwords.Add(new Password(PasswordId, stringBuilderString.ToString(), alphabit.GetAlhapit()));
        }

        public void GenerateSomePasswords(IAlphabitComponent alphabit, int length, int amount)
        {
            for (int i = 0; i  <= amount; i++)
            {
                GeneratePassword(alphabit, length);
            }
        }

        /*
        protected string GetAlphabitString(bool useUpper, bool useLower, bool useNumbers)
        {
            var alphabitToUse = new StringBuilder();
            if (useUpper) alphabitToUse.Append(AlphabitConstants.UpperAlphabit);
            if (useLower) alphabitToUse.Append(AlphabitConstants.LowerAlphabit);
            if (useNumbers) alphabitToUse.Append(AlphabitConstants.Numbers);
            return alphabitToUse.ToString();
        }
        */
    }
}
