using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() // constructor
        {
            Cards = new List<Card>(); // first thing to do is instantiate the property Cards as an empty list of cards (you need to create the list before you can add values)
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; // create list for suits
            List<string> Faces = new List<string>() 
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            }; // create list with faces

            // so now we have 2 lists, one with 4 items and one with 13. 4 * 13 = 52 which is the total number of cards in a deck.

            // we use nested foreach to loop through.  For each value in the Faces list, we are going to loop through 4 times. So first loop will happen 13 times
            // and then second loop 4 times
            // during each loop, we create a card and then assign the Suit property the current value of suit in that loop and the Face property gets assigned the current
            // value of the face were are on in the loop.
            // then we add that card to the Cards list we created at the beginning of our constructor.
            // the "card" variable in the loop can be used repeatedly because it only occurs within the loop and nowhere else.

            foreach(string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
