using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("motorcycle abstract");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
            Console.WriteLine("Motorcycle virtual");
        }
    }
}
