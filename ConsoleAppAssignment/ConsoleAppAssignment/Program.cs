using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {

        //// Part 1 - Create a string array and ask for user to input text.  
        //// Iterate through array and add input text to the end of each string.
        //// Print each modified string on new line.
        //string[] stringArray = {"Hello ", "The best name ever is ", "If I only had 1 last cookie to share, I would give it to ", "I think I will name my first born ", "I once knew a cat named "};

        //Console.WriteLine("Please enter your name.");
        //string name = Console.ReadLine();

        //for (int i = 0; i < stringArray.Length; i++)
        //{
        //   string completeSentence = stringArray[i] + name;
        //   Console.WriteLine(completeSentence);
        //}

        //Console.ReadLine();

        // Part 2 - Create an infinite loop.

        //Console.WriteLine("Press \"Enter\" key to demonstrate infinite loop.");
        //int count = 0;

        //while (true)
        //{
        //    Console.WriteLine("Count = {0}.", count);

        //    if (count > 10)
        //    {
        //        break;
        //    }
        //}
        //Console.ReadLine();

        // Infinite loop corrected.

        //int count = 0;

        //while (true)
        //{
        //    Console.WriteLine("Count = {0}.", count);
        //    count++;

        //    if (count > 10)
        //    {
        //        break;
        //    }
        //}
        //Console.ReadLine();

        //// Part 3 Loop with a < operator

        //Console.WriteLine("Please enter a number.");
        //int num = Convert.ToInt32(Console.ReadLine());

        //while (true)
        //{
        //    if (num < 10)
        //    {
        //        Console.WriteLine("You entered " + num + " which is less than 10.");
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("You entered " + num + " which is greater than 10.");
        //        break;
        //    }

        //}

        //Console.ReadLine();

        //// Part 3 Loop with <= operator
        //Console.WriteLine("Please enter a number.");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //while(true)
        //{
        //    if (num2 <= 10)
        //    {
        //        Console.WriteLine("You entered " + num2 + " which is less than or equal to 10.");
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("You entered " + num2 + " which is greater than 10.");
        //        break;
        //    }

        //}
        //Console.ReadLine();

        //List<string> provinces = new List<string> { "Nova Scotia", "New Brunswick", "Ontario", "Alberta", "Saskatchewan", "Quebec" };
        //Console.WriteLine("Please enter the name of a Canadian province.");
        //string input = Console.ReadLine();

        //foreach (string province in provinces)
        //{
        //     if (input == "Nova Scotia")
        //    { 
        //        Console.WriteLine("{0}",
        //        provinces.IndexOf(input));
        //        break;
        //    }
        //    else if (input == "New Brunswick")
        //    {
        //        Console.WriteLine("{0}",
        //        provinces.IndexOf(input));
        //        break;
        //    }
        //    else if (input == "Ontario")
        //    {
        //        Console.WriteLine("{0}",
        //        provinces.IndexOf(input));
        //        break;
        //    }
        //    else if (input == "Alberta")
        //    {
        //        Console.WriteLine("{0}",
        //        provinces.IndexOf(input));
        //        break;
        //    }
        //    else if (input == "Saskatchewan")
        //    {
        //        Console.WriteLine("{0}",
        //        provinces.IndexOf(input));
        //        break;
        //    }
        //    else if (input == "Quebec")
        //    {
        //        Console.WriteLine("{0}",
        //        provinces.IndexOf(input));
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("That province is either mispelled or not in my list");
        //        break;
        //    }                      
        //}

        //Console.ReadLine();

        List<string> mprovinces = new List<string> { "Nova Scotia", "New Brunswick", "Prince Edward Island", "Nova Scotia"};
        Console.WriteLine("Enter one of the following maritime provinces: \nNova Scotia, \nNew Brunswick, \nPrince Edward Island\n");
        string input = Console.ReadLine();
        List<int> indices = new List<int>();

        for(int i = 0; i < mprovinces.Count; i++)
        {
            if (input == "Nova Scotia")
            {
                Console.WriteLine("{0}",
                mprovinces.IndexOf(input));

                break;
            }
            else if (input == "New Brunswick")
            {
                Console.WriteLine("{0}",
                mprovinces.IndexOf(input));
                break;
            }
            else if (input == "Prince Edward Island")
            {
                Console.WriteLine("{0}",
                mprovinces.IndexOf(input));
                break;
            }
            else
            {
                Console.WriteLine("Sorry, that's not in my list.");
                break;
            }
        }
        Console.ReadLine();
    }
}

