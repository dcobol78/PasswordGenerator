using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Password
    {
        public string PasswordId { get; private set; }

        public string PasswordContent {  get; private set; }

        public Password(string passwordId, string passwordContent)
        {
            PasswordId = passwordId;
            PasswordContent = passwordContent;
        }
    }
}
