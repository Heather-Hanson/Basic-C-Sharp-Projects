using System;


    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);

            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number. ");
            return; // the message won't run if you use return without a finally below
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally // can be helpful if you need to log something to a database. This will always run no matter what happens above.
        {
            Console.ReadLine();  
        }
        Console.ReadLine();
        }
    }

