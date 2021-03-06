﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            if(playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only. No decimals.");
            }
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if(answer == "yes"|| answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Heather\source\repos\Heather-Hanson\Basic-C-Sharp-Projects\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();

                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
        private static void UpdateDBWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30;
                                        Encrypt = False; TrustServerCertificate = False; 
                                        ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", System.Data.SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30;
                                        Encrypt = False; TrustServerCertificate = False; 
                                        ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}


//public static Deck Shuffle(Deck deck, int times)
//{
//    for (int i = 0; i < times; i++)
//    {
//        deck = Shuffle(deck);
//    }
//    return deck;
//}
// Camel case is preferred naming convention for var in C#
// Deck and Card classes are the datatypes ex: Deck (datatype) deck (var) = new (instance) Deck(datatype)

//Method: 
//Public = accessible everything, Static = because we don't want create an object Program before calling it, 
//Deck = data type it is returning, Shuffle = name of the function,
//Deck = type of parameter it is taking, deck = variable name we use when we refer to it inside of our method


// instead of doing below, which can be tedious, we will create a constructor on the Deck class.
//deck.Cards = new List<Card>();

//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//deck.Cards.Add(cardOne);

// Method overloading allows you to use methods of the same name multiple times as long as they are slightly different.

// Polymorphism: Object TwentyOneGame can morph into a higher order object Game (because TwentyOneGame inherits from Game, Game is higher order)
// another example for using polymorphism: creating a list of different type classes (Example, list of games, then add TwentyOneGame, Poker game, etc...
// Syntax: 
//List<Game> games = new List<Game>();
//TwentyOneGame game = new TwentyOneGame();
//games.Add(game);
// Polymorphism: Ability of a class to morph into it's inheriting class to gain certain advantages.

//Enum is a data type.  Used to represent constant values.  
// public enum DaysOfTheWeek
//{
//Monday,
//Tuesday,
//Wednesday etc..(no quotes needed.)
//}
//Enums can help avoid user input error. 
//Intellisense helps when instantiating enums
//You can cast an enum to another underlying datatype: int underlyingValue = (int)Suit.Diamonds; ==== this would display a value of 1 because of it's
// position in the list (default starts at 0), but you can assign items specific numeric values as well (ex. Diamonds=10)

// Classes in C# operate by reference (real life exampe is the shared doc in Google)
// ex: Card card1 = new Card();
// Card card2 = card1;
// card1.Face = Face.Eight;
// card2.Face = Face.King;
// When written to the console, the above would display card1 with a face of King because card2 references the memory where card1 is located and therefore overrides the initial
// value of card1.

// Any data type that stores value by reference is called a reference type and by rule of thumb that includes all classes as are Lists, Strings.

// a Value type would be the example where the student sent a COPY of the essay via email.
// Built in value types are: int, bool, enum, datetime

// string is an alias for the class String
// int is an alias for the struct Int32

// Simply, a struct is a Class that is value type.  Can't be inherited.
// Value types can't have a value of null

// by changing the Card class to a struct, the example above would print "Eight" to the console.

// Lambda functions (ex.  Count).  Lambda operator =>. Exposes a List to a variety of different functions.
// example: int count = deck.Cards.Count(x => x.Face == Face.Ace);
// x is like a variable, it can be anything.

// More Lambda examples:
//-----------------------------------------------------------------------------------------------------
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

//foreach(Card card in newList)
//{
//    Console.WriteLine(card.Face);

//}
//------------------------------------------------------------------------------------------------------
//List<int> numberList = new List<int>() { 1, 2};
//int sum = numberList.Sum(x => x + 5); //takes each item in the list and adds 5 before summing them all up

//Console.WriteLine(sum);
//------------------------------------------------------------------------------------------------------
//List<int> numberList = new List<int>(){1,2,3, 21, 42};
// int sum = numberList.Where(x => x > 20).Sum();
// Console.WriteLine(sum);

// Lambda reduce the amount of code and can be better than for loops
// BUT lambda are hard to debug and really hard when you start chaining them together (also hard to read)

//named paramaters would look like: Shuffle(deck: deck, times: 3).  Helps with reading.

//When you make chanegs to your library you need to build the library again for changes to be available in your program.

// You can use var instead of the datatypes now.  (ex: string name = "Heather" could be var name = "Heather") However, in some cases defining the data type can help with readability.

// Constants - once the program is compiled it doesn't change.
// const string casinoName = "Grand Hotel and Casino";

//Guid = Global Unique Identifier

//In bigger connections, your SQL connection string will most likely be in a config file (so you can just call the method)
