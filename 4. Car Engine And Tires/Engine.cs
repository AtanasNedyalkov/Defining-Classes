using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class Engine
    {
        public int HorsPower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int horsPower, double cubicCapacity)
        {
            HorsPower = horsPower;
            CubicCapacity = cubicCapacity;
        }
        public static void Run()
        {
            Console.WriteLine("I'm an engine. I am running");
        }
    }
}
