using GameShop.Models;

namespace GameShop.Interfaces
{
    public interface IAllGames
    {
        IEnumerable<Games> games { get; }
        IEnumerable<Games> getFavoriteGames { get; }
        Games GetGame(int gameID);
    }
}
