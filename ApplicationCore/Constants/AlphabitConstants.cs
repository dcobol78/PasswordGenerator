using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Constants
{
    public record AlphabitConstants
    {
        public const string FullAlphabitWithNumbers = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
        public const string UpperAlphabit = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string LowerAlphabit = "abcdefghijklmnopqrstuvwxyz";
        public const string Numbers = "1234567890";
        //public const string SpecialSimbols = "!@#$%^&*()_+-=";
    }
}
