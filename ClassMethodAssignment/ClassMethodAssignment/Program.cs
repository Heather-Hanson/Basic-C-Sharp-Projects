using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate my Math Class
            Math math = new Math();

            // Request input from user and take that input and divide it by the output integer in the method
            Console.WriteLine("Please enter a number.");
            math.Divide(Convert.ToInt32(Console.ReadLine()), out int num2);

            // Demonstrate method that has 2 output parameters
            Console.WriteLine("\nDemonstration of a method with output paramters: ");
            math.Add(out int num, out int num1);

            // Overload method demo
            Console.WriteLine("\nDemonstration of an overloaded method.  Same name as the previous method, but changing it to static and output paramters to input parameters.");
            Console.WriteLine("\nPlease enter a number");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int sum = Math.Add(input1, input2);
            Console.WriteLine("Your first number: {0} plus your second number: {1} equals: {2}.", input1, input2, sum);

            // Calling my static class
            Name.MyName();
            Console.WriteLine("\n This is my static class that displays my name: {0} {1}", Name.FirstName, Name.LastName );

            Console.ReadLine();

        }
    }
}
