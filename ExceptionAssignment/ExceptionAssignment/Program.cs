using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            List<int> divisors = new List<int> { 2, 4, 6, 8 };
            Console.WriteLine("Please enter a number to divide");
            int dividend = Convert.ToInt32(Console.ReadLine());

            foreach (int divisor in divisors)
            {
                int quotient = divisor / dividend;
                Console.WriteLine(divisor + " divided by " + dividend + " equals " + quotient);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("The program has emerged from the try/catch block");
            Console.ReadLine();
        }

        }
    }

