using ApplicationCore.Constants;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Alphabit
{
    public class UpperDecorator : IAlphabitComponent
    {
        private readonly IAlphabitComponent _alphabet;
        public UpperDecorator(IAlphabitComponent alphabet)
        {
            _alphabet = alphabet ?? throw new ArgumentNullException(nameof(alphabet));
        }

        public string GetAlhapit()
        {
            return _alphabet.GetAlhapit() + AlphabitConstants.UpperAlphabit;
        }
    }
}
