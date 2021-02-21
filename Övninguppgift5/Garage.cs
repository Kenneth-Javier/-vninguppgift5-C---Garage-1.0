using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    internal class Garage<T> : IEnumerable<T> where T : IVehicle
    {
        private T[] vehicles;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Park(T item)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is null)
                {
                    vehicles[i] = item;
                    H.PrintL($"vehicles[{i}] new {vehicles[i].VehicleType}");
                    break;
                }
                if (vehicles.Length == i)
                {
                    H.PrintL($"vehicles[] garage full! Only Capacity for {i} vehicles");
                }
            }
        }
        //under construktion
        public void CountVehicles()
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                var s = vehicles[i].GetType().Name;
                var n = vehicles[i].GetType().Name;
                H.PrintL($"{i}.{s}: {n}");
            }
        }

        public bool RegExist(string s) 
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i]?.RegNr == s)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ColorExist(string s) { return vehicles.Any(w => w.Color == (ConsoleColor)H.IntParsedValue(s)); }
        public bool NumOfWeelsExist(string s) { return vehicles.Any(v => v.NumOfWeels == H.IntParsedValue(s)); }
        public bool TransportationOnExist(string s) { return vehicles.Any(w => w.TransportationOn == s); }
        public bool PassengersExist(string s) { return vehicles.Any(w => w.Passengers == H.IntParsedValue(s)); }
        
        public bool Remove(string s)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {               
                if(vehicles[i].RegNr == s)
                {
                    H.Print($"{vehicles[i].Color} {vehicles[i].VehicleType} {vehicles[i].RegNr}"); 
                    vehicles[i] = default(T);
                    return true;
                }
            }
            return false;
        }

        public Garage(int capacity)
        {
            if (capacity is not 0) vehicles = new T[capacity];
            H.PrintL($"Garage-Vehicles[] capacity :{vehicles.Length} ");           
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
    }
}
