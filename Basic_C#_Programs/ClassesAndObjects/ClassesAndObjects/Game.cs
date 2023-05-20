using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>(); //to instantiate some list before actual players list created
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>(); //instantiate dictionary before actual dictionary created
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public abstract void Play(); //abstract method with no implementation
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        

        public virtual void ListPlayers() //basic virtual method with some implementation
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }


    }
}
