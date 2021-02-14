using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    class Bus : Vehicle
    {
        public int HorsePower { get; set; }
        public Bus(string vehicleRegistrationNumber, ConsoleColor color, int numberOfWeels, string transportationOn, int passengers, int horsePower) : base(vehicleRegistrationNumber, color, numberOfWeels, transportationOn, passengers)
        {
            HorsePower = horsePower;
        }
    }
}
