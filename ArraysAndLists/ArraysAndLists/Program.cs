using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        //lists are called generics because you can create a list of any data type.  They use the "System.Collections.Generic" up above.

        //Data type of a list, name of list, new instance of a list<data type>
        //Lists are very adaptable and commonly used in programming. Many methods for lists.
        //Arrays will be used when you have a fixed quantity that you know won't change grouped together because once you set the size it is difficult to change.
        //Another time you will use arrays is if you are storing large quantities of something
        //For most other cases, you will use a List.
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Heather");


        Console.WriteLine(stringList[0]);
        Console.ReadLine();


        ////define data type of array int[], name array "numArray", instantiate array "new", "integer" [] = "array".  Length needs to be set for arrays in C# [5]
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        ////below is a shorter way of accomplishing above.
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //the length is still set with this instance

        ////below is the shortest way of creating an array 
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //// you can change the values of the array by referencing the index, but you can't change the size of an array once it is set.
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
        }
    }

