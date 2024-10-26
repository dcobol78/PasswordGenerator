using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Password : IPassword
    {
        public string Id { get; set; }
        public string PasswordContent {  get; private set; }
        public string UsedAlphabit { get; private set; }

        public Password(string id, string passwordContent, string usedAlphabit)
        {
            Id = id;
            PasswordContent = passwordContent;
            UsedAlphabit = usedAlphabit;
        }
    }
}
