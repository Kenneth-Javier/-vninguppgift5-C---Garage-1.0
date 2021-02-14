using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    internal class Airplane : Vehicle
    {
        public int WingSpan { get; set; }
        public Airplane(string vehicleRegistrationNumber, ConsoleColor color, int numberOfWeels, string transportationOn, int passengers, int wingspan) : base(vehicleRegistrationNumber, color, numberOfWeels, transportationOn, passengers)
        {
            WingSpan = wingspan;
        }
    }
}
