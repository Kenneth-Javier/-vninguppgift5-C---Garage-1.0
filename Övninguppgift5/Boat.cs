using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    internal class Boat : Vehicle
    {
        public int Hight { get; set; }
        public Boat(string vehicleRegistrationNumber, ConsoleColor color, int numberOfWeels, string transportationOn, int passengers, string vehicleType, int hight) 
            : base(vehicleRegistrationNumber, color, numberOfWeels, transportationOn, passengers, vehicleType)
        {
            Hight = hight;
        }

        public override string Print()
        {
            return $"{ base.Print()}, and is {Hight}m high";
        }
    }
}
