using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one of the days of the week.");
            string day = Console.ReadLine();
            bool result = false;

            while (!result) 
            {
                switch (day)
                {
                    case "Monday":
                        Console.WriteLine("Yuck!");
                        Console.WriteLine("What day is next?");
                        day = Console.ReadLine();
                        break;
                    case "Tuesday":
                        Console.WriteLine("Tacos!!");
                        Console.WriteLine("What day is next?");
                        day = Console.ReadLine();
                        break;
                    case "Wednesday":
                        Console.WriteLine("Hump-DAY!");
                        Console.WriteLine("What day is next?");
                        day = Console.ReadLine();
                        break;
                    case "Thursday":
                        Console.WriteLine("Getting better!");
                        Console.WriteLine("What day is next?");
                        day = Console.ReadLine();
                        break;
                    case "Friday":
                        Console.WriteLine("Everybody's workin' for the weekend!");
                        Console.WriteLine("What day is next?");
                        day = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("It's the weekend!  YAY!!");
                        result = true;
                        break;
                }
            }

            Console.WriteLine("Can you guess my age?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool myAge = false;

            do
            {
                switch (age)
                {
                    case 9:
                        Console.WriteLine("You guessed I was 9??  You must think I'm some sort of prodigy!");
                        Console.WriteLine("Try again!");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 65:
                        Console.WriteLine("You guessed 65!  Not quite...though retirement does sound nice!");
                        Console.WriteLine("Try again!");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 38:
                        Console.WriteLine("You got it right!  You are so smart!");
                        myAge = true;
                        break;
                    default:
                        Console.WriteLine("Guess again!");
                        Console.WriteLine("Try again!");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!myAge);

            Console.ReadLine();
        }
    }
}
