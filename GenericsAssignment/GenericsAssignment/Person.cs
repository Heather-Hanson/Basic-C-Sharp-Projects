
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

    }
}
