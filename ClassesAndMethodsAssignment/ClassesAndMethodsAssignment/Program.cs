using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to enter number, pass it to my Multiply method.  Since I am passing an integer it uses the method that accepts integers
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int product1 = Math.Multiply(num1);
            Console.WriteLine("Your number {0} multiplied by 22 equals {1}", num1, product1);

            // Ask user for a decimal pass it to Multiply method, since number is decimal it uses the method that accepts decimals.
            Console.WriteLine("Please enter a decimal number");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            decimal product2 = Math.Multiply(num2);
            Console.WriteLine("Your number {0} multiplied by 5 equals {1}", num2, product2);

            // Ask user for another number, it is passed to Multiply method as a string based on the variable I created, and therefore users the method that allows for strings to pass
            Console.WriteLine("Please enter a number");
            string num3 = Console.ReadLine();
            int product3 = Math.Multiply(num3);
            Console.WriteLine("Your number {0} multiplied by 2 equals {1}", num3, product3);

            Console.ReadLine();

        }

    }
}
