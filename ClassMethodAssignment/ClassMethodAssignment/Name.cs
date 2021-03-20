using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    //Static class
    public static class Name
    {
        public static string FirstName = "Heather";
        public static string LastName = "Hanson";

        public static void MyName()
        {
            Console.WriteLine("My name is: {0} {1}", FirstName, LastName);
        }
    }
}
