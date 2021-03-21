using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; } // the reason we did a property instead of inheritance is because a Dealer is not a Deck (whereas when TwentyOneGame inherited Game, TwentyOne IS a game)
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); // we remove the first index item from our list since we have dealt it
        }
    }
}
