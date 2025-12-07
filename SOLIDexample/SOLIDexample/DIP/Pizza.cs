using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.DIP
{
    internal class Pizza
    {
        public Pizza(ICut instrument)
        {
            instrument.Cut();
        }

        public void Sell()
        {
            Console.WriteLine("Sold");
        }
    }
}
