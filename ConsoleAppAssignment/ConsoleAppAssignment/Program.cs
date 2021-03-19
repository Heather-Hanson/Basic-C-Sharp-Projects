using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {

        //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        //List<int> passingScores = new List<int>();

        //foreach(int score in testScores)
        //{
        //    if(score > 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}

        //Console.WriteLine(passingScores.Count);

        //Console.ReadLine();
    

    // Part 1 - Create a string array and ask for user to input text.  
    // Iterate through array and add input text to the end of each string.
    // Print each modified string on new line.
    string[] stringArray = { "Hello ", "The best name ever is ", "If I only had 1 last cookie to share, I would give it to ", "I think I will name my first born ", "I once knew a cat named " };

        Console.WriteLine("Please enter your name.");
        string name = Console.ReadLine();

        for (int i = 0; i < stringArray.Length; i++)
        {
            string completeSentence = stringArray[i] + name;
            Console.WriteLine(completeSentence);
        }

        Console.ReadLine();

        //Part 2 - Create an infinite loop.
        // This loop is infinite because the variable count does not increment so is always 0. The program only stops when the variable count is greater than 10.

        //Console.WriteLine("Press \"Enter\" key to demonstrate infinite loop.");
        //int count = 0;

        //while (true)
        //{
        //    Console.WriteLine(count);

        //    if (count > 10)
        //    {
        //        break;
        //    }
        //}
        //Console.ReadLine();

        // Part 2 - Infinite loop corrected.
        // By incrementing the variable after each round in the loop it will eventually become greater than 10 and exit the program.

        int count2 = 0;

        while (true)
        {
            Console.WriteLine(count2);
            count2++;

            if (count2 > 10)
            {
                break;
            }
        }
        Console.ReadLine();

        // Part 3 Loop with a < operator
        // The program will loop through whil the variable entererd is less than 10. Each round of the loop will first add an increment to the initial number the user entered.

        Console.WriteLine("Please enter a number.");
        int num = Convert.ToInt32(Console.ReadLine());

        while (num < 10)
        {
            num++;
            Console.WriteLine(num);

        }
        Console.ReadLine();

        // Part 3 Loop with <= operator
        // Same as above, but the loop will go around one more time once it gets to 10, since I have added "equals".
        Console.WriteLine("Please enter a number.");
        int num2 = Convert.ToInt32(Console.ReadLine());
        while (num2 <= 10)
        {
            num2++;
            Console.WriteLine(num2);

        }
        Console.ReadLine();


        // Part 4 - Create a list and prompt user to enter value. 
        // Program puts value in "input" variable and loops through each item in thelist and outputs the index number. Changes boolean to true and then will exit program.
        // If after looping through, no match is found (match !=true), user gets notified no match is found.

        List<string> provinces = new List<string> { "Nova Scotia", "New Brunswick", "Ontario", "Alberta", "Saskatchewan", "Quebec" };
        Console.WriteLine("Please enter the name of a Canadian province.");
        string input = Console.ReadLine();
        bool match = false;

        for (int i = 0; i < provinces.Count; i++)
        {
            if (provinces[i] == input)
            {
                match = true;
                Console.WriteLine(i);
            }
        }

        if (match != true)
        {
            Console.WriteLine("Sorry, this is not in the list");
        }
        Console.ReadLine();


        // Part 5 - Create a list where two strings have matching values. Get user to input a value from the list and then display all indices related to that value.
        // I used same loop as before as it delivered the desired results, even when there was more than once instance of a string in the list.

        List<string> mprovinces = new List<string> { "Nova Scotia", "New Brunswick", "Prince Edward Island", "Nova Scotia" };
        Console.WriteLine("Enter one of the following maritime provinces: \nNova Scotia, \nNew Brunswick, \nPrince Edward Island\n");
        string input2 = Console.ReadLine();
        bool match2 = false;

        for (int i = 0; i < mprovinces.Count; i++)
        {
            if (mprovinces[i] == input2)
            {
                match2 = true;
                Console.WriteLine(i);
            }
        }

        if (match2 != true)
        {
            Console.WriteLine("Sorry, this is not in the list");
        }

        Console.ReadLine();

        // Part 6 - Create a list of strings with at least two identical values and create a for loop that displays the sting and whether or not it has already appeared in the list.
        // I created my list and then created an empty list named "Prev" so that once the loop has gone through, the value will be added to the "prev" list.
        // Each time through the current day value is compared to the "prev" list using the Contains method.  
        // If the day value is in the prev list, it states that it has already been listed, otherwise it states that it has not yet been listed.

        List<string> longWeekend = new List<string> { "Friday", "Saturday", "Sunday", "Saturday" };
        List<string> prev = new List<string>();

        foreach (string day in longWeekend)
        {
            if (prev.Contains(day))
            {
                Console.WriteLine(day + " was already listed");
            }
            else
            {
                Console.WriteLine(day + " has not yet been listed");
            }
            prev.Add(day);
        }

        Console.ReadLine();


    }
    
}

