using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interfaces
{
    public interface IAllGames
    {
        IEnumerable<Games> games { get; set; }
        IEnumerable<Games> getFavoriteGames { get; set;}
        Games GetGame(int gameID);
    }
}
