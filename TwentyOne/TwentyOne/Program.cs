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
            deck = Shuffle(deck);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //Method: Public = accessible everything, Static = because we don't want create an object Program before calling it, 
        //Deck = data type it is returning, Shuffle = name of the function,
        //Deck = type of parameter it is taking, deck = variable name we use when we refer to it inside of our method

        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random(); //C# class, new instance of it

            while(deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}

// Camel case is preferred naming convention for var in C#
// Deck and Card classes are the datatypes ex: Deck (datatype) deck (var) = new (instance) Deck(datatype)


// instead of doing below, which can be tedious, we will create a constructor on the Deck class.
//deck.Cards = new List<Card>();

//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//deck.Cards.Add(cardOne);