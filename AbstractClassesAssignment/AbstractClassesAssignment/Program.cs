using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee object
            Employee employee = new Employee();
            // Create values for properties
            employee.FirstName = "Heather";
            employee.LastName = "Hanson";

            //Call SayName method
            employee.SayName();
            Console.ReadLine();
        }
    }
}
