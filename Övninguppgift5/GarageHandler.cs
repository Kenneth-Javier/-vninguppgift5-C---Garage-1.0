using System;
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
        readonly Dictionary<char, ConsoleColor> DConsoleColor = new Dictionary<char, ConsoleColor>
                {
                    {'1', ConsoleColor.Black},
                    {'2', ConsoleColor.White },
                    {'3', ConsoleColor.Blue},
                    {'4', ConsoleColor.Red},
                    {'5', ConsoleColor.Yellow},
                    {'6', ConsoleColor.Green}
                };
        readonly Dictionary<string, string> DtransportationOn = new Dictionary<string, string>
                {
                    {"Airplane", "air"},
                    {"Motorcycle","road"},
                    {"Car", "road"},
                    {"Bus", "road"},
                    {"Boat", "water"}
                };
        readonly Dictionary<string, string> DspecialityOf = new Dictionary<string, string>
                {
                    {"Airplane", "Wingspan"},
                    {"Motorcycle","forklenght"},
                    {"Car", "MaxVelocity"},
                    {"Bus", "HorsePower"},
                    {"Boat", "Hight"}
                };
        readonly Dictionary<char, string> DvehicleType = new Dictionary<char, string>
                {
                    { '1',"Airplane" },
                    { '2',"Motorcycle" },
                    { '3',"Car" },
                    { '4',"Bus" },
                    { '5',"Boat" }
                };
        readonly Dictionary<int, Type> Dtype = new Dictionary<int, Type>
        {
                    { 1, typeof(Car) },
                    { 2, typeof(Bus) },
                    { 3, typeof(Boat) },
                    { 4, typeof(Airplane) },
                    { 5, typeof(Motorcycle) },
                    { 6, typeof(Boat) }
        };
        public Garage<Vehicle> G;
        readonly UImenu U = new UImenu();
        public GarageHandler(int capacity) => G = new Garage<Vehicle>(capacity);
        public IEnumerator GetEnumerator() => GetEnumerator();
        public void Park<T>(T item) => G.Park(item as Vehicle);

        internal void Case1ListVehicles() { foreach (var item in G) { H.PrintL(item.Print()); } }

        internal void Case2CountTypes()
        {

            //for (int i = 0; i < G.Count(); i++)
            //{
            //    if (Dtype.ContainsKey(i))
            //    {
            //        Type aui = Dtype[i];
            //        H.PrintL($"vehicleType {Dtype[i]} ");
            //        
            //    //int va = G.Where(v => v is aui.Count();
            //    }
            //}
            int airplanes = G.Where(v => v is Airplane).Count();
            int motorcycles = G.Where(v => v is Motorcycle).Count();
            int cars = G.Where(v => v is Car).Count();
            int buses = G.Where(v => v is Bus).Count();
            int boats = G.Where(v => v is Boat).Count();

            if (airplanes > 0)H.PrintL($"{airplanes} {nameof(airplanes)} ");
            if (motorcycles > 0) H.PrintL($"{motorcycles} {nameof(motorcycles)} ");
            if (cars > 0) H.PrintL($"{cars} {nameof(cars)} ");
            if (buses > 0) H.PrintL($"{buses} {nameof(buses)} ");
            if (boats > 0) H.PrintL($"{boats} {nameof(boats)} ");
            //Iterera över  garage med en foreach
            //kolla v.GetType().Name av vaje fordon
            //ha en counter för de olika förekomsterna
            //printa ut varje typ med dess antal

            //order by mm
        }
        //private int coV(Type v) { return G.Where(v => v is v).Count();}


        internal void Case3AddVehicleInGarage()
        {
            string vehicleType = DvehicleType[VehicleTypechoise()];
            string transportationOn = DtransportationOn[vehicleType];
                H.PrintL($"\nContinue adding propertys to your {vehicleType} entering {DspecialityOf[vehicleType]}: ");
            int special = H.GetIntegerFromUser();
                H.PrintL($"\nnumber of weels:");
            int numberOfWeels = H.GetIntegerFromUser();
                H.PrintL($"\nnumber of passengers:");
            int passengers = H.GetIntegerFromUser();
            ConsoleColor color = Colorchoise();             
            string reg = MakeANewReg();

            bool success = false;
            
            if (vehicleType == "Airplane") { G.Park(new Airplane(reg, color, numberOfWeels, transportationOn, passengers, vehicleType, special)); success = true; }
            if (vehicleType == "Motorcycle") { G.Park(new Motorcycle(reg, color, numberOfWeels, transportationOn, passengers, vehicleType, special)); success = true; }
            if (vehicleType == "Car") { G.Park(new Car(reg, color, numberOfWeels, transportationOn, passengers, vehicleType, special)); success = true; }
            if (vehicleType == "Bus") { G.Park(new Bus(reg, color, numberOfWeels, transportationOn, passengers, vehicleType, special)); success = true; }
            if (vehicleType == "Boat") { G.Park(new Boat(reg, color, numberOfWeels, transportationOn, passengers, vehicleType, special)); success = true; }
            
            if (success) { H.PrintL($"Success! new {vehicleType} added!"); }

        }

        public bool Case4Remove() 
        {
            do
            {
                var reg = AskForRegNr();
                if (G.RegExist(reg))
                {
                    return G.Remove(reg);
                }
                else
                {
                    H.PrintL("does not exist... ");
                    if (!H.ContinueOrQuit()) { return false; }
                }
            } while (true);
        }


        internal void Case6PopVehicle()
        {
            var L = new List<Vehicle> { };
            var car = new Car("HeL666", ConsoleColor.Red, 4, "road", 4, "car", 250);
            var airplane = new Airplane("aIr154", ConsoleColor.Cyan, 3, "air", 200, "airplane", 30);
            var bus = new Bus("bus154", ConsoleColor.Green, 6, "road", 40, "bus", 400);
            var motorcycle = new Motorcycle("aBc123", ConsoleColor.Yellow, 2, "road", 2, "motorcycle", 120);
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
                H.Print($""
                    + "\n   7. Hitta ett specifikt fordon via registreringsnummret."
                    + "\n   Det ska gå fungera med både ABC123 samt Abc123 eller AbC123."
                    + "\n "
                    + "\n Sök ");
            do
            {
                var regNr = AskForRegNr();
                //var result = G.Where(w => w.RegNr == regNr);
                if (G.RegExist(regNr)) { 
                var result = G.Where(w => w.RegNr == regNr);
                foreach (var item in result) { H.PrintL($"Found a {item.Print()}"); }
                menuActual = false;
                }
                else 
                {
                    menuActual = H.ContinueOrQuit();
                }

            } while (menuActual);
        }
        
        //part of case8
        public void Case8SearchForVehicleByValues()
        {
            G.CountVehicles();
          //Vehicle result;
          //result= G.FirstOrDefault(w => w.RegNr == what);
          //result = G.FirstOrDefault(w => w.Color == (ConsoleColor)H.IntParsedValue(what)) ;
          //result = G.FirstOrDefault(w => w.NumOfWeels == H.IntParsedValue(what));
          //result = G.FirstOrDefault(w => w.TransportationOn == what);
          //result = G.FirstOrDefault(w => w.Passengers == H.IntParsedValue(what));
          //result = G.FirstOrDefault(w => w.VehicleType == what);
            //  result = G.Where(w => w.GetType().GetElementType() == s);
            // result = G.FirstOrDefault(foreach (var item in Vehicle)
            // {
            //
            // }              
           // var g = result.VehicleType;
           // return result;
        }

        public string MakeANewReg()
        {
                H.Print($""
                    + "\n   Hitta ett unikt registreringsnmumer."
                    + "\n   Det ska gå fungera med både ABC123 samt Abc123 eller AbC123."
                    + "\n "
                    + "\n Testa med ");
            do
            {
                var regNr = AskForRegNr();
                if (G.RegExist(regNr)) { H.PrintL($" already exist... Try again."); }
                else if(!G.RegExist(regNr))return regNr; 

            } while (true);
        }
        
        public static string AskForRegNr()
        {
            H.Print("Reg: ");
            do
            {
                var s = Console.ReadLine();
                if (s.Length == 6)
                {
                    s = s.ToUpper();
                    return s;
                }
                else { H.PrintL($"  Endast 6st Bokstäver/Siffror...\n"); }
            } while (true);

        }

        private char VehicleTypechoise()
        {
                H.PrintL("\nPlease navigate through the menu by inputting the number "
                            + "\n(1, 2, 3, 4, 5, 0) of your choice"
                            + "\n Add a new vehicle in the garage:\n"
                            + "\n1. Airplane\n2. Motorcycle\n3. Car\n4. Bus\n5. Boat"
                            + "\n0. Back to Main menu"
                            + "\n ");
            do
            {
                //char c = ' ';
                char c = H.GetCharFromUser();
                //try { c = Console.ReadLine()[0]; }
                //catch (IndexOutOfRangeException) { Console.Clear(); ValuesOfStrings.PrintL("Please enter some input!"); }
                
                if (DvehicleType.ContainsKey(c))
                {
                    H.PrintL($"vehicleType {DvehicleType[c]} ");
                    return c;
                }
                else if (c == '0') { U.Menu(); }
                else { H.PrintL("Please enter some valid input (1, 2, 3, 4, 5, 0)"); }
            } while (true);
        }

        private ConsoleColor Colorchoise()
        {
            H.PrintL($"\nPlease navigate through the menu by inputting the number "
             + $"\n(1, 2, 3, 4, 5, 6, 0) of your choice"
             + $"\n Chose Color:\n"
             + $"\n1. Black\n2. White\n3. Blue\n4. Red\n5. Yellow\n6. Green"
             + $"\n0. Back to Main menu"
             + $"\n ");
            //char x = ' ';
            //try{
            do
            {
                char x = H.GetCharFromUser();
            if (DConsoleColor.ContainsKey(x)) { H.PrintL($"{DConsoleColor[x]} "); return DConsoleColor[x];  }
            else if (x == '0') { U.Menu(); }
            else { H.PrintL("Please enter some valid input (1, 2, 3, 4, 5, 6, 0)"); }
                //}catch (IndexOutOfRangeException) { Console.Clear(); ValuesOfStrings.PrintL("Please enter some input!"); }
            } while (true);

        }

    
    
    }
}
