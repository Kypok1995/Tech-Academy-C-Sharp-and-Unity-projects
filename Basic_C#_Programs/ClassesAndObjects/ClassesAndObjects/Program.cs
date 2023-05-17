using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program	

    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Black Jack game! Please enter your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money you bring today to play?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to start a game right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" )
            {
                Player player = new Player(playerName, bank); //instantiate a new player with user's input name and balance
                Game game = new TwentyOneGame(); // instantiate new game
                game += player; // add a player to the game
                player.isActivelyPlaying = true; //set property of actively  playing to true

                while(player.isActivelyPlaying $$ player.Balance >0) //game can be played while player is active and have some balance
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing my Black Jack game!");
            }
            Console.WriteLine("All right, let's play a game next time!");
        }

    }
}
