using ApplicationCore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Alphabit
{
    public class NumbersDecorator : IAlphabitComponent
    {
        private readonly IAlphabitComponent _alphabet;
        public NumbersDecorator(IAlphabitComponent alphabet)
        {
            _alphabet = alphabet ?? throw new ArgumentNullException(nameof(alphabet));
        }

        public string GetAlhapit()
        {
            return _alphabet.GetAlhapit() + AlphabitConstants.Numbers;
        }
    }
}
