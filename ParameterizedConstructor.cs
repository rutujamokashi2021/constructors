using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// C# Program to illustrate calling of
// parameterized constructor.
namespace constructors
{
    public class ParameterizedConstructor
    {// data members
        String name;
        int id;
        ParameterizedConstructor(String name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public static void Main()
        {
            ParameterizedConstructor paracon = new ParameterizedConstructor("Rutuja", 101);
            Console.WriteLine("paracon name =" +paracon.name + "and paracon id =" +paracon.id);
           

        }
    }
}