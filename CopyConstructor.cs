using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// C# Program to illustrate calling
// a Copy constructor
namespace constructors
{
    public class CopyConstructor
    {
        private string month;
        private int year;
        // declaring Copy constructor
        public CopyConstructor(CopyConstructor c)
        {
            month = c.month;
            year = c.year;
        }
        // Instance constructor
        public CopyConstructor(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

        // Get details of CopyConstructor
        public string Details 
        {
        get
            {
                return "Month : " + month.ToString() +
                        "\n Year :" + year.ToString();
            }
        }
        public static void Main()
        {
            // object creation
            CopyConstructor copycon1 = new CopyConstructor("December",2022);
            // copycon1 details is copied to copycon2
            CopyConstructor copycon2 = new CopyConstructor(copycon1);
            Console.WriteLine(copycon2.Details);
        }
    
    }
}