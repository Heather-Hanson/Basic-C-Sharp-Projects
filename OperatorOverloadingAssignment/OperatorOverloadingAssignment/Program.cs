using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate Employee objects
            Employee employee = new Employee() { FirstName = "Heather", Id = 1234 };
            Employee employee1 = new Employee() { FirstName = "Jesse", Id = 5678 };

            // compare employees using == operator.  It will know to compare the ID of the employees when I do this
            bool compare = employee == employee1;

            // display result of comparison
            Console.WriteLine("Heather's ID is {0}, Jesse's is {1}. Do they match? {2}", employee.Id, employee1.Id, compare);

            Console.ReadLine();

        }
    }
}