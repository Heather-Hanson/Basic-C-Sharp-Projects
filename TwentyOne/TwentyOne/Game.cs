using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); 
        public virtual void ListPlayers()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}

// Abstract method.  Contains no implementation. All it does is force any class inheriting Game define this method
// Virtual method exists in abstract class. Virtual methods have implementation, but can be overridden in inherited classes.
//Example: We used the ListPlayers method in TwentyOneGame, but added text to the console