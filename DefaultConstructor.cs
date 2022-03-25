using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// C# Program to illustrate calling
// a Default constructor
namespace constructors
{
    public class DefaultConstructor
    {
        int num;
        string name;

        // this would be invoked while the object of that class created
        DefaultConstructor()//Constructor
        {
            Console.WriteLine("Constructor called");
        }
        public static void Main()
        {
            //this would invoke default constructor
            DefaultConstructor dfcon = new DefaultConstructor();
            Console.WriteLine(dfcon.name);
            Console.WriteLine(dfcon.num);
        }
    }
}