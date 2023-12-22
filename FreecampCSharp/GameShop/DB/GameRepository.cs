using GameShop.Interfaces;
using GameShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GameShop.DB
{
    public class GameRepository : IAllGames
    {
        private readonly AppDBContent appDBContent;
        public GameRepository(AppDBContent appDBContent, IEnumerable<Games> games, IEnumerable<Games> getFavoriteGames)
        {
            this.appDBContent = appDBContent;
 
        }

        public IEnumerable<Games> games => appDBContent.Games.Include(g => g.Category);//to get all games categories
        public IEnumerable<Games> getFavoriteGames => appDBContent.Games.Where(g => g.isFavorite).Include(c => c.Category);//retrieve favourite games info


        public Games GetGame(int gameID) => appDBContent.Games.FirstOrDefault(g => g.gameID == gameID);//retrieve game information based on game ID
 
    }
}
