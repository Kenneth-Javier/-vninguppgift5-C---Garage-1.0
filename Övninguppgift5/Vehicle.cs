using System;
using System.Collections;

namespace Övninguppgift5
{
    abstract class Vehicle : IVehicle
    {
        public string RegNr { get;  set; }
        public ConsoleColor Color { get; set; }
        public int NumOfWeels { get; set; }
        public string TransportationOn { get; set; }
        public int Passengers { get; set; }
        public string VehicleType { get; set; }
  
        public Vehicle(string registrationNumber, ConsoleColor color, int numOfWeels,
            string transportationOn, int passengers, string vehicleType)
        {
            RegNr = registrationNumber.ToUpper();
            Color = color;
            NumOfWeels = numOfWeels;
            TransportationOn = transportationOn;
            Passengers = passengers;
            VehicleType = vehicleType.ToLower();
        }

        public virtual string Print()
        {
            return $"{Color} {VehicleType} with Regno: {RegNr}, have {NumOfWeels} wheels, drives on {TransportationOn}, {Passengers}passengers";
        }

    }
}