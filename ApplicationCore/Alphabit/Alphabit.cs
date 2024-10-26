using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Alphabit
{
    public class Alphabit : IAlphabitComponent
    {
        private readonly string _content;

        public Alphabit(string content = "")
        {
            _content = content;
        }

        public string GetAlhapit()
        {
            return _content;
        }
    }
}
