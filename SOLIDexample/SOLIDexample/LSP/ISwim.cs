using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.LSP
{
    internal interface ISwim
    {
        int SwimSpeed { get; set; }

        void Swim();
    }
}
