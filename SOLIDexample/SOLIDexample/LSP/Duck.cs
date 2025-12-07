using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.LSP
{
    internal class Duck : Bird, ISwim,IFly
    {
        public int FlySpeed { get; set ; }
        public int SwimSpeed { get ; set ; }

        public Duck()
        {
            
        }
        public void Fly()
        {
            Console.WriteLine("Duck flied away");
        }

        public void Swim()
        {
            Console.WriteLine("Duck swam away");
        }
    }
}
