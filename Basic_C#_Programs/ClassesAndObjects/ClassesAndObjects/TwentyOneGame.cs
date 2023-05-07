using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play() //abstract method from abstract class with implementation in inherited class. Inherited class must have implementation for abstract method
        {
            throw new NotImplementedException();
        }

        public override void ListPlayers() //override virtual method from Game class
        {
            Console.WriteLine("21 players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotFiniteNumberException();
        }
    }
}
