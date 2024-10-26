using ApplicationCore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Alphabit
{
    public class LowerDecorator : IAlphabitComponent
    {
        private readonly IAlphabitComponent _alphabet;
        public LowerDecorator(IAlphabitComponent alphabet)
        {
            _alphabet = alphabet ?? throw new ArgumentNullException(nameof(alphabet));
        }

        public string GetAlhapit()
        {
            return _alphabet.GetAlhapit() + AlphabitConstants.LowerAlphabit;
        }
    }
}
