﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    class UImenu
    {
        Asist As = new Asist();
        GarageHandler garageHandler;
        List<object> o = new List<object>();

        public static int capacity = 0;

        public void Menu()
        {
            ValuesOfStrings.StrOut($"Welcome to the game! ");
            bool capacityLoop = true;
            do 
            {
            ValuesOfStrings.StrOut($"\nSätt en kapacitet (antal parkeringsplatser) för ett nytt garage");
            var str = Console.ReadLine();
            if (ValuesOfStrings.IsStringInt(str) && !string.IsNullOrEmpty(str))
            {
                capacityLoop = false;
                capacity = ValuesOfStrings.IntParsedValue(str);
                garageHandler = new GarageHandler(capacity);
            }
            } while (capacityLoop);
            bool menuActual = true; 
            do{

                ValuesOfStrings.StrOut("\nPlease navigate through the menu by inputting the number "
               + "\n(1, 2, 3 ,4, 5, 6, 7, 8, 0) of your choice"

               + "\n1. Lista samtliga parkerade fordon" //klar
               + "\n2. Lista fordonstyper och hur många av varje som står i garaget"
               + "\n3. Lägga till fordon i garaget"// klar
               + "\n4. Ta bort fordon ur garaget"

              // + "\n5. Sätta en kapacitet (antal parkeringsplatser) vid instansieringen av ett nytt garage" //Klar
               + "\n6. Möjlighet att populera garaget med ett antal fordon från start." // Klar
              
               + "\n7. Hitta ett specifikt fordon via registreringsnumret." //Klar
               + "\n   Det ska gå fungera med både ABC123 samt Abc123 eller AbC123."
               + "\n8. Söka efter fordon utifrån en egenskap eller flera(alla möjliga kombinationer frånbasklassen Vehicle)."
               + "\n   Exempelvis: "
               + "\n     *Alla svarta fordon med fyra hjul. "
               + "\n     *Alla motorcyklar som är rosa och har 3 hjul."
               + "\n     *Alla lastbilar "
               + "\n     *Alla röda fordon "
               + "\n0. Exit the application" //Klar
               + "\n ");
                char input = ' '; 
                try
                {
                    input = Console.ReadLine()[0]; 
                }
                catch (IndexOutOfRangeException) 
                {
                    Console.Clear();
                    ValuesOfStrings.StrOut("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        //Lista samtliga parkerade fordon
                        garageHandler.Case1ListVehicles();
                        break;
                    case '2':
                        
                        break;
                    case '3':
                        //Lägga till fordon i garaget"                 
                        garageHandler.Case3AddVehicleInGarage();
                        break;
                    case '4':
                        
                        break;
                    case '6':
                        //Möjlighet att populera garaget med ett antal fordon från start.
                        garageHandler.Case6PopVehicle();
                        break;
                    case '7':
                        //Hittar ett specifikt fordon via registreringsnumret."
                        garageHandler.Case7FindVehicle();

                        break;
                    case '8':

                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        ValuesOfStrings.StrOut("Please enter some valid input (1, 2, 3, 4, 5, 6, 7, 8, 0)");
                        break;
                }

            } while(menuActual);

        }
        
    }
}
