using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// C# Program to illustrate calling
// a Private constructor
namespace constructors
{
    public class PrivateConstructor
    { 
        // declare private Constructor
        private PrivateConstructor()
        {
        }

        // declare static variable field
        public static int count_geeks;

        // declare static method
        public static int geeks_Count()
        {
            return ++count_geeks;
        }

        // Main Method
        public static void Main()
        {

            // If you uncomment the following
            // statement, it will generate
            // an error because the constructor
            // is unaccessible:
            // Geeks s = new Geeks(); // Error

            PrivateConstructor.count_geeks = 99;

            // Accessing without any
            // instance of the class
            PrivateConstructor.geeks_Count();

            Console.WriteLine(PrivateConstructor.count_geeks);

            // Accessing without any
            // instance of the class
            PrivateConstructor.geeks_Count();

            Console.WriteLine(PrivateConstructor.count_geeks);
        }
    }
}