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
        public Boat(string vehicleRegistrationNumber, ConsoleColor color, int numberOfWeels, string transportationOn, int passengers, int hight) : base(vehicleRegistrationNumber, color, numberOfWeels, transportationOn, passengers)
        {
            Hight = hight;
        }


    }
}
