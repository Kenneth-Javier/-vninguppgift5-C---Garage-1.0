using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övninguppgift5
{
    class Asist
    {


        public string ToLower(string str)
        {
            string s = str.ToLower();
            return s;
        }

        public void exampleToLower()
        {

            String A = "ABC123";
            String B = "Abc123";
            String C = "AbC123";
            Console.WriteLine($"String A = ABC123 :{A}"
                                + $"\nString B = Abc123 :{B}"
                                + $"\nString C = AbC123 :{C}");

            A = A.ToLower();
            B = B.ToLower();
            C = C.ToLower();
            Console.WriteLine($"\nexampleToLower()"
                            + $"\nString A = ABC123 :{A}"
                            + $"\nString B = Abc123 :{B}"
                            + $"\nString C = AbC123 :{C}");
        }

    }
}
