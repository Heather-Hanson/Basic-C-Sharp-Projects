using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            int product = Convert.ToInt32(input) * 50;
            Console.WriteLine("Your number multiplied by 50 equals: " + product);

            Console.WriteLine("Please enter another number:");
            string input2 = Console.ReadLine();
            int sum = Convert.ToInt32(input2) + 25;
            Console.WriteLine("Your number plus 25 equals: " + sum);

            Console.WriteLine("Please enter another number:");
            string input3 = Console.ReadLine();
            double quotient = Convert.ToDouble(input3) / 12.5;
            Console.WriteLine("Your number divided by 12.5 equals: " + quotient);

            Console.WriteLine("Please enter another number:");
            string input4 = Console.ReadLine();
            bool compare = Convert.ToInt32(input4) > 50;
            Console.WriteLine("Is your number greate than 50?  " + compare);

            Console.WriteLine("Please enter another number:");
            string input5 = Console.ReadLine();
            int remainder = Convert.ToInt32(input5) % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + remainder);

            Console.ReadLine();

        }
    }
}
