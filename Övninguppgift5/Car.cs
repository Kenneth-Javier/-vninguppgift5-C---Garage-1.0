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
        public Car(string registrationNumber, ConsoleColor color, int numberOfWeels, string transportationOn, int passengers,string vehicleType, int maxKmH) 
            : base(registrationNumber, color, numberOfWeels, transportationOn, passengers, vehicleType)
        {
            MaxKmH = maxKmH;
        }

        public override string Print()
        {
            return $"{ base.Print()}, maximum velocity {MaxKmH}km/h";
        }
    }
}
