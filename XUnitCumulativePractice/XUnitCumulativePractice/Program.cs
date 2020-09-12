using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace XUnitCumulativePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /*
         * Create a method in XUnitCumulativePractice.Program.cs called ValidateOneToOneHundredEven() that will accept a string (“1” or “20” etc.) 
         * as a parameter (ensure your “Program” class is public).
            Validate that the string:
            Is an integer (numeric, will safely parse to int).
            Is between 1 and 100.
            Is even.
            If it is, return true. Otherwise return false.
         */
        public static bool ValidateOneToOneHundredEven(string myString)
        {

            bool isNumeric = int.TryParse(myString, out int i);
            if (isNumeric)
            {
                if (i >= 1 && i<=100)
                {
                    if (i % 2 == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
