using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_QuoteApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            //Enter weight to determine if weight fits criteria
            Console.WriteLine("Please enter the package weight");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Weight cannot be greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            // If weight is less than or equal to 50 then the program will continue
            else
            {
                Console.WriteLine("Please enter the package width");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the package height");
                decimal height = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the package length");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                // If sum of package dimensions is greater than 50 program ends
                if(width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                // Package dimensions less than or equal to 50 will provide shipping total
                else
                {
                    decimal total= (width * height * length) * weight /100;                  
                    Console.WriteLine("Your estimated total for shipping this package is: $" + Math.Round(total,2));
                    Console.WriteLine("Thank you.");
                }

            }
            Console.ReadLine();
        }
    }
}
