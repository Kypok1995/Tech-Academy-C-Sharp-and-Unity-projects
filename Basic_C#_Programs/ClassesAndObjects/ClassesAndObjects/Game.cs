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
        public abstract void Play(); //abstract method with no implementation

        public string Dealer { get; set;  }

        public virtual void ListPlayers() //basic virtual method with some implementation
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
