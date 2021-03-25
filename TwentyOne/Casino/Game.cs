using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }

        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set {_bets = value; } }

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