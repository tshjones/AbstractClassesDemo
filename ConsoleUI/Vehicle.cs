using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set;}
        public string Make { get; set; }
        public string Model { get; set; }

        public abstract void DriveAbstract();

        public override string ToString()
        {
            return Year + " " + Make + " " + Model;
        }
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Vehicle Virtual Drive");
        }
    }
}
