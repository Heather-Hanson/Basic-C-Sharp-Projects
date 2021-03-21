using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate Employee class
            Employee employee = new Employee();

            // create values for employee first name and last name calling properites from inherited class: Person
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // call method from inherited class: Person
            employee.SayName();
            Console.ReadLine();

        }
    }
}
