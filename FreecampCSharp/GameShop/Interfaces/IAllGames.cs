using GameShop.Models;

namespace GameShop.Interfaces
{
    public interface IAllGames
    {
        IEnumerable<Games> games { get; set; }
        IEnumerable<Games> getFavoriteGames { get; set; }
        Games GetGame(int gameID);
    }
}
