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


        internal void Case1ListVihecles(){ foreach (var item in G) { ValuesOfStrings.StrOut(item.Print());} }

        public void Case6PopVihecle()
        {
            var L = new List<Vehicle> { };
            var car = new Car("HeL666", ConsoleColor.Red, 4, "road", 4,"car", 250);
            var airplane = new Airplane("aIr154", ConsoleColor.Cyan, 3, "air", 200, "airplane", 30);
            var bus = new Bus("bus154", ConsoleColor.Green, 6, "road", 40, "bus", 400);
            var motorcycle = new Motorcycle("boA949", ConsoleColor.Yellow, 2, "road", 2, "motorcycle", 120);
            var boat = new Boat("bOA949", ConsoleColor.White, 0, "water", 2000, "boat", 40);

            L.Add(car);
            L.Add(airplane);
            L.Add(bus);
            L.Add(motorcycle);
            L.Add(boat);
            foreach (var item in L) { G.Park(item); }
        }
            

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
                    ValuesOfStrings.StringValue(s);
                    var result = G.Where(w => w.RegistrationNumber == s);
                    foreach (var item in result) { ValuesOfStrings.StrOut($"Found! {item.Print()}"); }
                    menuActual = false;
                }
                else { ValuesOfStrings.StringValue($"  Endast 6st Bokstäver/Siffror...\n"); }

            } while (menuActual);
        }
    }
}
