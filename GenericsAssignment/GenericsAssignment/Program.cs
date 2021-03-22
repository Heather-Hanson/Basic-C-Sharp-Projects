using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate list string
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            employee.Things.Add("Desk");
            employee.Things.Add("Chair");

            //instantiate list int
            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>();
            employee1.Things.Add(1);
            employee1.Things.Add(3);

            //loop through both lists and display values for Things
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();

        }
    }
}