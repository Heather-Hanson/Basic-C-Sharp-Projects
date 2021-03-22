using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            deck.Shuffle(3);
            //named paramaters would look like: Shuffle(deck: deck, times: 3).  Helps with reading.

            foreach (Card card in deck.Cards)

            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
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