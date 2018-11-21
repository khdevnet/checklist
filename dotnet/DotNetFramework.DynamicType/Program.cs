using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFramework.DynamicType
{
    internal static class DynamicDemo
    {
        public static void Main()
        {
            dynamic value;
            for (Int32 demo = 0; demo < 2; demo++)
            {
                value = (demo == 0) ? (dynamic)5 : (dynamic)"A";
                value = value + value;
                M(value);
            }
        }
        // Called first because dynamic type is Int32
        private static void M(Int32 n) { Console.WriteLine("M(Int32): " + n); }

        // Called second because dynamic type is String
        private static void M(String s) { Console.WriteLine("M(String): " + s); }
    }
}