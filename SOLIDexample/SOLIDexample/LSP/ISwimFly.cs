using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.LSP
{
    internal interface ISwimFly
    {
         int FlySpeed { get; set; }
         int SwimSpeed { get; set; }

        void Fly();
        void Swim(); 
    }
}
