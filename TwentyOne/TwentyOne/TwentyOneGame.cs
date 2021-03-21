using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway // using : you can set class to inherit. You can't inherit multiple classes, but you can with interfaces
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
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}

//When you call a method from a class you inherited, it is called a super class.