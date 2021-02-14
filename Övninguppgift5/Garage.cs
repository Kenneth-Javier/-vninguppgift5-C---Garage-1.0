using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    //Garaget: En representation av själva byggnaden. 
    //Garaget är en plats där en mängd av fordon kan förvaras.
    //Garaget kan alltså representeras som en samling av fordon.
    internal class Garage<T> : IEnumerable<T> where T : IVehicle
    {
        private T[] vehicles;


        //Det skall alltså gå att parkera fordon,// count capasity of array, implement later
        public void Park(T item)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if(vehicles[i] is null)
                {                    
                    vehicles[i] = item;
                    Console.WriteLine($"vehicles[{i}] new {vehicles[i]}");
                    break;
                }
            }
        }
        ////hämta ut fordon, 
        //public Vehicle DriveOut(Vehicle v)
        //{
        //    foreach (var item in vehicles)
        //    {
        //     if(vehicles.Contains(item)) 
        //        {
        //            try { 
        //                return item; 
        //            }
        //            catch { }
        //        }       
        //
        //    }
        //}

        public void findVehicle(String sNum)
        {
            string s = sNum;
            var b = vehicles.Where(w => w.VehicleRegistrationNumber.Contains(sNum));
            Console.WriteLine(b);
           // Asist asist;

           // var o = from items in vehicles where items.VehicleRegistrationNumber.Contains(sNum);
        }

        internal void Park(string v1, object yellow, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal void Park(string v1, ConsoleColor foregroundColor, object red, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public void FindPos()
        {
            //my first where test <3
            var h = vehicles.Where(n => n?.NumberOfWeels > 12 ).Select(n => n.Color);
            var p = vehicles.Where(n => n?.VehicleRegistrationNumber == "fff666")
                .Where(a => a?.NumberOfWeels == 4).Where(s => s?.Passengers > 2)
                .Where(u => u?.Color == ConsoleColor.Cyan);
            


            
        }
        //se efter vilka fordon som finns där 
        public void vehiclesInGarage() { }

        //och vilka egenskaper de har.
        public void qtysOfV() {}


        public Garage(int capacity)
        {
            if (capacity is not 0) vehicles = new T[capacity]; //check not  -
            ValuesOfStrings.StrOut($"Garage-Vehicles[] capacity :{vehicles.Count()} ");
            //else capacity = 0;
            
        }


        public IEnumerator<T> GetEnumerator()
        {
            //Yield return all vehicles! not null :)
            foreach (var item in vehicles)
            {
                if (item is not null)
                    yield return item;
            }
            
            
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
