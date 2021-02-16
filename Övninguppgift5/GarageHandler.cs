﻿using System;
using System.Collections;
using System.Collections.Immutable;
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
        UImenu U = new UImenu();
        public GarageHandler(int capacity) => G = new Garage<Vehicle>(capacity);
        public IEnumerator GetEnumerator() => GetEnumerator();
        public void Park<T>(T item) => G.Park(item as Vehicle);

        internal void Case1ListVehicles(){ foreach (var item in G) { ValuesOfStrings.StrOut(item.Print());} }

        internal void Case3AddVehicleInGarage()
        {
            string reg =null;                      //k
            ConsoleColor color =ConsoleColor.Black;//k
            
            int numberOfWeels = 0;              //k
            string transportationOn =null;      //k
            int passengers = 0;                 //k

            string vehicleType = null;          //k
            int special = 0;                    //k
            string s;


            bool menuActual = true;
            bool menuActual2 = true;
            do
            {
                ValuesOfStrings.StrOut("\nPlease navigate through the menu by inputting the number "
                            + "\n(1, 2, 3, 4, 5, 0) of your choice"
                            + "\n Add a new vehicle in the garage:\n"
                            + "\n1. Airplane\n2. Motorcycle\n3. Car\n4. Bus\n5. Boat"
                            + "\n0. Back to Main menu"
                            + "\n ");
                char c = ' ';
                try { c = Console.ReadLine()[0]; }
                catch (IndexOutOfRangeException) { Console.Clear(); ValuesOfStrings.StrOut("Please enter some input!"); }
                Dictionary<char, ConsoleColor> DConsoleColor = new Dictionary<char, ConsoleColor>
                {
                    {'1', ConsoleColor.Black},
                    {'2',ConsoleColor.White },
                    {'3', ConsoleColor.Blue},
                    {'4', ConsoleColor.Red},
                    {'5', ConsoleColor.Yellow},
                    {'6', ConsoleColor.Green}
                };
                Dictionary<string, string> DtransportationOn = new Dictionary<string, string>
                {
                    {"Airplane", "air"},
                    {"Motorcycle","road"},
                    {"Car", "road"},
                    {"Bus", "road"},
                    {"Boat", "water"}
                };
                Dictionary<string, string> DspecialityOf = new Dictionary<string, string>
                {
                    {"Airplane", "Wingspan"},
                    {"Motorcycle","forklenght"},
                    {"Car", "MaxVelocity"},
                    {"Bus", "HorsePower"},
                    {"Boat", "Hight"}
                };
                Dictionary<char, string> DvehicleType = new Dictionary<char, string>
                {
                    { '1',"Airplane" },  
                    { '2',"Motorcycle" },
                    { '3',"Car" },
                    { '4',"Bus" },
                    { '5',"Boat" }  
                };
                if (DvehicleType.ContainsKey(c)) {
                    vehicleType = DvehicleType[c];
                    transportationOn = DtransportationOn[vehicleType];
                    ValuesOfStrings.StrOut($"{vehicleType} ");
                }
                else if (c == '0') { U.Menu(); }
                else{ ValuesOfStrings.StrOut("Please enter some valid input (1, 2, 3, 4, 5, 0)"); }
                
                ValuesOfStrings.StrOut($"\nContinue adding propertys to your {DvehicleType[c]} entering {DspecialityOf[vehicleType]}: ");
                do
                {
                    try { s = Console.ReadLine();
                    if (ValuesOfStrings.IsStringInt(s))
                        {special = ValuesOfStrings.IntParsedValue(s);
                            menuActual2 = false;
                        }
                    }catch (IndexOutOfRangeException) { Console.Clear(); ValuesOfStrings.StrOut("Please enter some input!"); }
                } while (menuActual2);
                ValuesOfStrings.StrOut($"\nnumber of weels:");
                do
                {
                    try
                    {
                        s = Console.ReadLine();
                        if (ValuesOfStrings.IsStringInt(s))
                        {
                            numberOfWeels = ValuesOfStrings.IntParsedValue(s);
                            menuActual2 = false;
                        }
                        else { menuActual2 = true; }
                    }
                    catch (IndexOutOfRangeException) { Console.Clear(); ValuesOfStrings.StrOut("Please enter some input!"); }
                } while (menuActual2);
                ValuesOfStrings.StrOut($"\nnumber of passengers:");
                do
                {
                    try
                    {
                        s = Console.ReadLine();
                        if (ValuesOfStrings.IsStringInt(s))
                        {
                            passengers = ValuesOfStrings.IntParsedValue(s);
                            menuActual2 = false;
                        }
                        else { menuActual2 = true; }
                    }
                    catch (IndexOutOfRangeException) { Console.Clear(); ValuesOfStrings.StrOut("Please enter some input!"); }
                } while (menuActual2);
                ValuesOfStrings.StrOut($"\nPlease navigate through the menu by inputting the number "
                            + $"\n(1, 2, 3, 4, 5, 6, 0) of your choice"
                            + $"\n Chose Collor to your {vehicleType}:\n"
                            + $"\n1. Black\n2. White\n3. Blue\n4. Red\n5. Yellow\n6. Green"
                            + $"\n0. Back to Main menu"
                            + $"\n ");
                char x = ' ';
                try { x = Console.ReadLine()[0];
                    if (DConsoleColor.ContainsKey('x'))
                    {
                        color = DConsoleColor[x];
                        ValuesOfStrings.StrOut($"{color} ");
                    }
                    else if (c == '0') { U.Menu(); }
                    else { ValuesOfStrings.StrOut("Please enter some valid input (1, 2, 3, 4, 5, 0)"); }
                }
                catch (IndexOutOfRangeException) { Console.Clear(); ValuesOfStrings.StrOut("Please enter some input!"); }
                do
                {
                    Console.Write($""
                        + "\n   Hitta ett unikt registreringsnmumer."
                        + "\n   Det ska gå fungera med både ABC123 samt Abc123 eller AbC123."
                        + "\n "
                        + "\n Testa : ");
                    string v = Console.ReadLine();
                    v = v.ToUpper();
                    if (v.Length == 6)
                    {
                        ValuesOfStrings.StringValue(v);
                        var result = G.Where(w => w.RegistrationNumber == v);
                        if (!result.Any()) 
                        { reg = v; menuActual2 = false; menuActual = false; }
                        else if (result.Any()) { menuActual2 = true; }
                    }
                    else { ValuesOfStrings.StringValue($"  Endast 6st Bokstäver/Siffror...\n"); }

                } while (menuActual2);

            } while (menuActual);


            bool success= false;
            if (vehicleType == "Airplane") { G.Park(new Airplane(reg, color, numberOfWeels, transportationOn, passengers, vehicleType, special)); success = true; }
            if (vehicleType == "Motorcycle") { G.Park(new Motorcycle(reg, color, numberOfWeels, transportationOn, passengers, vehicleType, special)); success = true; }
            if (vehicleType == "Car") { G.Park(new Car(reg, color, numberOfWeels, transportationOn, passengers, vehicleType, special)); success = true; }
            if (vehicleType == "Bus") { G.Park(new Bus(reg, color, numberOfWeels, transportationOn, passengers, vehicleType, special)); success = true; }
            if (vehicleType == "Boat") { G.Park(new Boat(reg, color, numberOfWeels, transportationOn, passengers, vehicleType, special)); success = true; }
            if (success) { ValuesOfStrings.StrOut($"Success! new {vehicleType} added!"); }

        }
        public void Case6PopVehicle()
        {
            var L = new List<Vehicle> { };
            var car = new Car("HeL666", ConsoleColor.Red, 4, "road", 4,"car", 250);
            var airplane = new Airplane("aIr154", ConsoleColor.Cyan, 3, "air", 200, "airplane", 30);
            var bus = new Bus("bus154", ConsoleColor.Green, 6, "road", 40, "bus", 400);
            var motorcycle = new Motorcycle("MCA999", ConsoleColor.Yellow, 2, "road", 2, "motorcycle", 120);
            var boat = new Boat("bOA949", ConsoleColor.White, 0, "water", 2000, "boat", 40);

            L.Add(car);
            L.Add(airplane);
            L.Add(bus);
            L.Add(motorcycle);
            L.Add(boat);
            foreach (var item in L) { G.Park(item); }
        }  

        public void Case7FindVehicle()
        {
            bool menuActual = true;
            do
            { 
                Console.Write($""
                    + "\n   7. Hitta ett specifikt fordon via registreringsnummret."
                    + "\n   Det ska gå fungera med både ABC123 samt Abc123 eller AbC123."
                    + "\n "
                    + "\n Sök: ");
                string s = Console.ReadLine();
                s = s.ToUpper();
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
