using ApplicationCore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Alphabit
{
    // Вынести конструктор в отдельный класс
    // Придумать что-то вместо констант
    public class DeafualtDecorator : IAlphabitComponent
    {
        private readonly IAlphabitComponent _alphabet;
        public DeafualtDecorator(IAlphabitComponent alphabet)
        {
            _alphabet = alphabet ?? throw new ArgumentNullException(nameof(alphabet));
        }

        public string GetAlhapit()
        {
            return _alphabet.GetAlhapit() + AlphabitConstants.FullAlphabitWithNumbers;
        }

    }
}
