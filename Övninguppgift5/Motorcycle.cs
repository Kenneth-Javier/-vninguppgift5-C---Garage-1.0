using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    class Motorcycle : Vehicle
    {
        public int Forklenght { get; set; }
        public Motorcycle(string vehicleRegistrationNumber, ConsoleColor color, int numberOfWeels, string transportationOn, int passengers, string vehicleType, int forkLenght)
            : base(vehicleRegistrationNumber, color, numberOfWeels, transportationOn, passengers, vehicleType)
        {
            Forklenght = forkLenght;
        }

        public override string Print()
        {
            return $"{ base.Print()}, {Forklenght}cm forklenght";
        }
    }
}
