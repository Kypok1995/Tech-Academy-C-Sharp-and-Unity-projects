using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interfaces
{
    public interface IAllGames
    {
        IEnumerable<Game> games { get; set; }
        IEnumerable<Game> getFavoriteGames { get; set;}
        Game GetGame(int gameID);
    }
}
