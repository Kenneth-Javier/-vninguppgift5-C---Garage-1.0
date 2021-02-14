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
        public Motorcycle(string vehicleRegistrationNumber, ConsoleColor color, int numberOfWeels, string transportationOn, int passengers, int forkLenght) : base(vehicleRegistrationNumber, color, numberOfWeels, transportationOn, passengers)
        {
            Forklenght = forkLenght;
        }
    }
}
