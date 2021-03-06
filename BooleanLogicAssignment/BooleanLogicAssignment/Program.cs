using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();

            Console.WriteLine("Qualified?");
            bool qualified = Convert.ToInt32(age) > 15 && (DUI == "false" || DUI == "no") && Convert.ToInt32(ticket) <= 3;
            Console.WriteLine(qualified);

            Console.ReadLine();
        }
    }
}
