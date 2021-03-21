using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game // using : you can set class to inherit
    {
        public override void Play() // override keyword to allow us to have it undefined for now
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }
    }
}

//When you call a method from a class you inherited, it is called a super class.