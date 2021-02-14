using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    class Car : Vehicle
    {
        public int MaxKmH { get; set; }
        public Car(string vehicleRegistrationNumber, ConsoleColor color, int numberOfWeels, string transportationOn, int passengers, int maxKmH) : base(vehicleRegistrationNumber, color, numberOfWeels, transportationOn, passengers)
        {
            MaxKmH = maxKmH;
        }
    }
}
