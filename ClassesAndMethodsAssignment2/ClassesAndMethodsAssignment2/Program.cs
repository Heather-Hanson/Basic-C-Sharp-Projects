using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number (not required)");
            string input2 = Console.ReadLine();

            if (input2.Equals(string.Empty))
            {
                Console.WriteLine("I took your number: {0} and added 5 for a sum of: {1}", num1, Math.Add(num1));
            }
            else
            {
                int num2 = Convert.ToInt32(input2);
                Console.WriteLine("Your first number: {0} plus your second number: {1}, equals: {2}", num1, num2, Math.Add(num1, num2));
                
            }

            Console.ReadLine();
        }
    }
}
