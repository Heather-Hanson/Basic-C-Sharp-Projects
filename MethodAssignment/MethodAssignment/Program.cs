using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number and I will perform some math for you!");
            // assign variable to user response
            int input = Convert.ToInt32(Console.ReadLine());

            // create variables to assign the different results of my 3 methods
            int sum = Integer.Sum(input);
            int remainder = Integer.Modifier(input);
            int product = Integer.Product(input);

            // call the variables in my output to the user to show them what the methods accomplished
            Console.WriteLine("\n Your number: " + input + " plus 6 equals " + sum);
            Console.WriteLine("\n The remainder of your number: " + input + " divided by 6 equals " + remainder);
            Console.WriteLine("\n Your number: " + input + " multiplied by 6 equals " + product);

            Console.ReadLine();
        }
    }
}
