using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// C# Program to illustrate calling
// a Static constructor

namespace constructors
{
    public class StaticConstructor
    {
      

        // It is invoked before the first
        // instance constructor is run.
        static StaticConstructor()
        {

            // The following statement produces
            // the first line of output,
            // and the line occurs only once.
            Console.WriteLine("Static Constructor");
        }

        // Instance constructor.
        public StaticConstructor(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        // Instance method.
        public string geeks_detail(string name, int id)
        {
            return "Name:" + name + " id:" + id;
        }

        // Main Method
        public static void Main()
        {

            // Here Both Static and instance
            // constructors are invoked for
            // first instance
            StaticConstructor obj = new StaticConstructor(1);

            Console.WriteLine(obj.geeks_detail("GFG", 1));

            // Here only instance constructor
            // will be invoked
            StaticConstructor obj1 = new StaticConstructor(2);

            Console.WriteLine(obj1.geeks_detail("GeeksforGeeks", 2));
        }
    }
}