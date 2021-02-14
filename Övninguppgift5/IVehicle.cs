using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    interface IVehicle 
    {

        //● Registreringsnumret är unikt

        string VehicleRegistrationNumber { get; set; }
        ConsoleColor Color { get; set; }
        int NumberOfWeels { get; set; }
        string TransportationOn { get; set; }
        int Passengers { get; set; }
       
        
        //string VehicleRegistrationNumber();
       //ConsoleColor Color(ConsoleColor color);
       //public int NumberOfWeels(int NoW);
       //public string TransportationOn(string tO);
       //public int Passengers(int P);




        //● Det måste minst finnas följande subklasser:

        //○ Airplane
        //○ Motorcycle
        //○ Car
        //○ Bus
        //○ Boat
        //● Dessa skall implement
    }
}
