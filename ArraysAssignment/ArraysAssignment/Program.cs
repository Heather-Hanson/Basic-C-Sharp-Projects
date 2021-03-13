using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {

        //String array
        string[] stringArray = { "Hello", "How are you?", "What's your name?", "How's the weather?" };

        Console.WriteLine("Pick a number from 0 to 3");
        int index = Convert.ToInt32(Console.ReadLine());

        //Switch statement for each option and default when non-index number is entered
        switch(index)
        {
            case 0:
                Console.WriteLine(stringArray[index]);
            break;

            case 1:
                Console.WriteLine(stringArray[index]);
            break;

            case 2:
                Console.WriteLine(stringArray[index]);
            break;

            case 3:
                Console.WriteLine(stringArray[index]);
            break;

            default:
                Console.WriteLine("That number is not a valid choice");
            break;
        }

        //Integer array
        int[] intArray = { 5, 20, 36, 65};

        Console.WriteLine("Pick a number from 0 to 3");
        int index2 = Convert.ToInt32(Console.ReadLine());

        //Switch statement for each option and a default when non-index number is entered
        switch (index2)
        {
            case 0:
                Console.WriteLine(intArray[index2]);
                break;

            case 1:
                Console.WriteLine(intArray[index2]);
                break;

            case 2:
                Console.WriteLine(intArray[index2]);
                break;

            case 3:
                Console.WriteLine(intArray[index2]);
                break;

            default:
                Console.WriteLine("That number is not a valid choice");
                break;
        }

        //String list
        List<string> stringList = new List<string>();
        stringList.Add("Hello!");
        stringList.Add("Have a nice day!");
        stringList.Add("Hang in there!");
        stringList.Add("You called an item from my list!");

        //Ask user to pick a number and display string from that index
        Console.WriteLine("Pick a number between 0 and 3");
        int index3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringList[index3]);    

        Console.ReadLine();
        }
    }

