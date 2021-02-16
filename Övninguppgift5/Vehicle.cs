using System;
using System.Collections;

namespace Övninguppgift5
{
    abstract class Vehicle : IVehicle
    {

        public string RegistrationNumber { get;  set; }
        public ConsoleColor Color { get; set; }
        public int NumOfWeels { get; set; }
        public string TransportationOn { get; set; }
        public int Passengers { get; set; }
        public string VehicleType { get; set; }
  
        public Vehicle(string registrationNumber, ConsoleColor color, int numOfWeels,
            string transportationOn, int passengers, string vehicleType)
        {
            RegistrationNumber = registrationNumber.ToUpper();
            Color = color;
            NumOfWeels = numOfWeels;
            TransportationOn = transportationOn;
            Passengers = passengers;
            VehicleType = vehicleType.ToLower();
        }

        public virtual string Print()
        {
            return $"This {Color} {VehicleType} with Regno: {RegistrationNumber}, have {NumOfWeels} wheels, drives on {TransportationOn}, {Passengers}passengers";
        }

    }
}