using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // create an instance for DaysOfTheWeek
                DaysOfTheWeek days = new DaysOfTheWeek();

                // ask user for input, assign it to a string var, create a variable for Days enum
                Console.WriteLine("Please enter the current day of the week.");
                string currentDay = Console.ReadLine();
                DaysOfTheWeek.Days day;

                // parse currentDay through day, if successful user is notifed, if not, catch exception fires
                // else through exception
                if(Enum.TryParse<DaysOfTheWeek.Days>(currentDay, out day))
                {
                    Console.WriteLine("You said today is {0}", currentDay);
                }
                else
                {
                    throw new Exception();
                }              
            }
            catch(Exception)
            {
                Console.WriteLine("Something went wrong.  Please make sure your day is written such as: Monday, Tuesday, Wednesday etc...");
            }
            
            Console.ReadLine();

        }
    }
}
