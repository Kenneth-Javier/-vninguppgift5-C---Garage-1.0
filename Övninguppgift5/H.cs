using System;
using System.Collections.Generic;
using System.Text;

namespace Övninguppgift5
{
    public class H
    {
        //Prints out strings with Line
        public static void PrintL(string str) { Console.WriteLine(str); }
        //Prints out strings without Line
        public static void Print(string str) { Console.Write(str); }
        //returns int value from string
        public static int IntParsedValue(string value) { int i = int.Parse(value);return i; }
        //returns double value from string
        public static double DoubleParsedValue(string value) { double d = double.Parse(value); return d; }
        //Makes sure string is string with value
        public static bool IsItStringOnlySValue(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (!string.IsNullOrWhiteSpace(str))
                {
                    if (IsStringInt(str)) return false;
                    else if (IsStringDouble(str)) return false;
                    else return true; 
                }
                return false;
            }
            return false;
        }

        //returns true if string is int
        public static bool IsStringInt(string str) { return int.TryParse(str, out int number); }

        //returns true if string is double
        public static bool IsStringDouble(string str) { return double.TryParse(str, out double db); }

        //require double input from user
        public static double GetDoubleFromUser()
        {
            do
            {
                try
                {
                    string input = Console.ReadLine();
                    if (IsStringDouble(input)) { return DoubleParsedValue(input); }
                }
                catch (IndexOutOfRangeException) { Console.Clear(); PrintL("Please enter some input!"); }
            } while (true);
        }

        //require int input from user
        public static int GetIntegerFromUser()
        {
            do
            {
                try
                {
                    string input = Console.ReadLine();
                    if (IsStringInt(input)){ return IntParsedValue(input);}
                }
                catch (IndexOutOfRangeException) { Console.Clear(); PrintL("Please enter some input!"); }
            } while (true);
        }

        public static char GetCharFromUser()
        {
            do
            {
                try
                {
                    return Console.ReadLine()[0];         
                }
                catch (IndexOutOfRangeException) { Console.Clear(); PrintL("Please enter some input!"); }
                catch (OutOfMemoryException) { Console.Clear(); PrintL("There is not enough memory!"); }
                catch (ArgumentOutOfRangeException){Console.Clear(); PrintL("ArgumentOutOfRangeException!"); }
            } while (true);
        }

        public static bool ContinueOrQuit()
        {
            PrintL($"Continue?"
                   + "\nPres Y / N ");
            do
            {
                char answer = GetCharFromUser();
                if (answer == 'Y' || answer == 'y') return true;
                if (answer == 'N' || answer == 'n') return false;
                else PrintL($"\nPres Y / N ");
            } while (true);
        }

    }
}
