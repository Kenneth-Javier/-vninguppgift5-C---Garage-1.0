using System;
using System.Collections.Generic;
using System.Text;

namespace Övninguppgift5
{
    public class ValuesOfStrings
    {


        //Prints out strings
        public static void StrOut(string str)
        {
            Console.WriteLine($"{str}");
        }


        //Makes sure string is string with value
        public static bool IsItStringWithValue(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (!string.IsNullOrWhiteSpace(str))
                {
                    if (IsStringInt(str))
                    {
                        return false;
                    }
                    else if (IsStringDouble(str))
                    {
                        return false;
                    }
                    else
                    {
                        StringValue(str);
                        return true;
                    }
                }
                return false;
            }
            return false;

        }

        //returns string value
        public static string StringValue(String str)
        {
            return str;
        }

        //returns true if string is int
        public static bool IsStringInt(string str)
        {
            int number = 0;
            bool success = false;
            success = int.TryParse(str, out number);
            if (success)
            {
                IntValue(number);
                return true;
            }
            else
            {
                return false;
            }
        }


        //returns int value from string
        public static int IntParsedValue(String value)
        {
            int i = int.Parse(value);
            return i;
        }
        //returns int value
        public static int IntValue(int value)
        {
            return value;
        }

        //returns true if string is double
        public static bool IsStringDouble(String str)
        {
            double db = 0;
            bool success = false;
            success = double.TryParse(str, out db);
            if (success)
            {
                DoubleValue(db);
                return true;
            }
            else
            {
                return false;
            }
        }

        //returns double value from string
        public static double DoubleParsedValue(String value)
        {
            double db = double.Parse(value);
            return db;
        }

        //returns double value
        public static double DoubleValue(double db)
        {
            return db;
        }

        public static int GetIntegerFromUser()
        {
            string str = null;
            do
            {
                try
                {
                    str = Console.ReadLine();
                    if (IsStringInt(str)){ return IntParsedValue(str);}
                }
                catch (IndexOutOfRangeException) { Console.Clear(); ValuesOfStrings.StrOut("Please enter some input!"); }
            } while (true);
        }

    }
}
