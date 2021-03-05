using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string p1rate_input = Console.ReadLine();
            int p1rate = Convert.ToInt32(p1rate_input);

            Console.WriteLine("Hours Worked?");
            string p1worked_input = Console.ReadLine();
            int p1worked = Convert.ToInt32(p1worked_input);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string p2rate_input = Console.ReadLine();
            int p2rate = Convert.ToInt32(p2rate_input);

            Console.WriteLine("Hours Worked?");
            string p2worked_input = Console.ReadLine();
            int p2worked = Convert.ToInt32(p2worked_input);

            Console.WriteLine("Annual salary of Person 1:");
            int p1salary = (p1rate * p1worked) * 52;
            Console.WriteLine(p1salary);

            Console.WriteLine("Annual salary of Person 2:");
            int p2salary = (p2rate * p2worked) * 52;
            Console.WriteLine(p2salary);

            Console.WriteLine("Person 1 makes more money than Person 2");
            bool compare = p1salary > p2salary;
            Console.WriteLine(compare);

            Console.ReadLine();

        }
    }
}
