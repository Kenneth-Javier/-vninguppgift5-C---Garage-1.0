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
                if(vehicles[i] is null)
                {                    
                    vehicles[i] = item;
                    ValuesOfStrings.StringValue($"vehicles[{i}] new {vehicles[i]}");
                    break;
                }
                if(vehicles.Length == i)
                {
                    ValuesOfStrings.StringValue($"vehicles[] garage full! Only Capacity for {i} vehicles");
                }
            }
        }

        public bool RegCheck(string s) { return vehicles.Any(v => v.RegNr == s); }

        public bool Remove(string s)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if(vehicles[i].RegNr == s)
                {
                    Console.Write($"{vehicles[i].Color} {vehicles[i].VehicleType} {vehicles[i].RegNr}"); 
                    vehicles[i] = default(T);
                    return true;
                }
            }
            return false;
        }

        public Garage(int capacity)
        {
            if (capacity is not 0) vehicles = new T[capacity];
            ValuesOfStrings.StrOut($"Garage-Vehicles[] capacity :{vehicles.Count()} ");           
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
