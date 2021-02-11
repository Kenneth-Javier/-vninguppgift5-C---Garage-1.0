using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    interface IVehicle :IEnumerable
    {

        //● Registreringsnumret är unikt
        public void VehicleRegistrationNumber();
        public void Color();
        public void NumberOfWeels();
        public void EnergySourse();
        public void TransportationOn();

        public void Passengers();

        //        Kravspecifikation
        //Fordonen ska implementeras som klassen Vehicle och subklasser till den.
        //● Vehicle innehåller samtliga egenskaper som ska finnas i samtliga fordonstyper.

        //T.ex.

        //registreringsnummer, 
        //färg, 
        //antalhjul 
     //och andra egenskaper ni kan komma på.
        //energikälla
        //färdmedel på


        //● Det måste minst finnas följande subklasser:

        //○ Airplane
        //○ Motorcycle
        //○ Car
        //○ Bus
        //○ Boat
        //● Dessa skall implement
    }
}
