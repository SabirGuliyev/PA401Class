using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.DIP
{
    internal interface ICut
    {
        public Knife Knife { get; set; }
        void Cut();
    }
}
