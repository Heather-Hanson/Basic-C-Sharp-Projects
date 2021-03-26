using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Please enter the age you will be turning (or have turned) this year.");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) throw new Exception();
                    if (age <= 0) throw new ExceptionHandling();

                }
                DateTime birthYear = DateTime.Now.AddYears(-age);
                Console.WriteLine("The year you were born was: {0}", birthYear.Year);
                Console.ReadLine();
                return;
            }
            catch (ExceptionHandling)
            {
                Console.WriteLine("Your age should be greater than zero!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please report to System Administrator");
                Console.ReadLine();
                return;
            }
        }
    }
}
