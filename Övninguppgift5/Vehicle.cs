using System;
using System.Collections;

namespace Övninguppgift5
{
    abstract class Vehicle : IVehicle
    {

        public Vehicle(string vehicleRegistrationNumber, ConsoleColor color, int numberOfWeels, string transportationOn, int passengers)
        {
            VehicleRegistrationNumber = vehicleRegistrationNumber;
            Color = color;
            NumberOfWeels = numberOfWeels;
            TransportationOn = transportationOn;
            Passengers = passengers;
        }

        public string VehicleRegistrationNumber { get; set; }
        public ConsoleColor Color { get; set; }
        public int NumberOfWeels { get; set; }
        public string TransportationOn { get; set; }
        public int Passengers { get; set; }

    }
}