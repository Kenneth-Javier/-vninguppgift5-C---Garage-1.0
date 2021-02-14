using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    class GarageHandler : IGarageHandler
    {
        public Garage<Vehicle> G;
        ValuesOfStrings VS = new ValuesOfStrings();





        public GarageHandler(int capacity) => G = new Garage<Vehicle>(capacity);
        public IEnumerator GetEnumerator() => GetEnumerator();
        public void Park<T>(T item) => G.Park(item as Vehicle);








        public void Case7FindVihecle()
        {
            bool menuActual = true;
            do
            {
                
                Console.Write($""
                    + "\n   7. Hitta ett specifikt fordon via registreringsnumret."
                    + "\n   Det ska gå fungera med både ABC123 samt Abc123 eller AbC123."
                    + "\n "
                    + "\n Sök: ");
                string s = Console.ReadLine();
                s = s.ToLower();
                if (s.Length == 6)
                {
                    Console.WriteLine(s);
                    Vehicle v = (Vehicle)G.Where(w => w.VehicleRegistrationNumber == s);
                    Console.WriteLine(v);
                }
                else { Console.Write($"  Endast 6st Bokstäver/Siffror...\n"); }

            } while (menuActual);
        }

        internal void Case6PopVihecle()
        { 
            var car = new Car("HeL666", ConsoleColor.Red, 4, "road", 4, 250);
            var vehicle = car;
            G.Park(vehicle);
           
        }
    }
}
