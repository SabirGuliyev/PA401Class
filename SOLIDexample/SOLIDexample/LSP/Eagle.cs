using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDexample.LSP
{
    //internal class Eagle:Bird,IFly
    internal class Eagle : Bird, IFly
    {
        //public int ClawPower { get; set; }
        //public int FlySpeed { get ; set; }

        //public void Fly()
        //{
        //    Console.WriteLine("Eagle Flied away");
        //}
        public int FlySpeed { get ; set ; }
       

        public void Fly()
        {
            Console.WriteLine("Flied away");
        }

       
    }
}
