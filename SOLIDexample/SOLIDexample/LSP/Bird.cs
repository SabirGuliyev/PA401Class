using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.LSP
{
    internal abstract class Bird
    {
        public int AvgLifetime { get; set; }
        protected Bird()
        {
            
        }

        public virtual void Eat() {
            Console.WriteLine("Grass");

        }
    }
}
