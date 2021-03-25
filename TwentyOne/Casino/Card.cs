using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card 
    {

        public Suit Suit { get; set; } 
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}



// Suit is a propery of datatype string. You can get it, or set it (only two things you can do with an object property)
// By making the property public it is accessable to other parts of the program. Same thing with the class itself.
// The class is just a plan or design for an object.  You still need to create the object in your program.
// Class is like a cookie cutter, object is the actual cookie.

// Constructor = values assigned to an object upon creation.  Constructor method name is always the name of the class.