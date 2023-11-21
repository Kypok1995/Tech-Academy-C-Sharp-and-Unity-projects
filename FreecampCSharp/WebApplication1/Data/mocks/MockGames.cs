using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
    public class MockGames : IAllGames
    {
        private readonly IGamesCategory _GameCategory = new MockCategory();
        public IEnumerable<Game> games
        {
            get
            {
                return new List<Game>
                {
                    new Game { gameName = "Oblivion", shortDescription = "", longDescription = "", image = "", price = 35, avaliable = true, isFavorite = true, Category = _GameCategory.AllCategories.First() },
                    new Game { gameName = "Need for Speed: Most Wanted", shortDescription = "", longDescription = "", image = "", price = 20, avaliable = true, isFavorite = true, Category = _GameCategory.AllCategories.ElementAt(3) },
                    new Game { gameName = "Fortnite", shortDescription = "", longDescription = "", image = "", price = 10, avaliable = true, isFavorite = false, Category = _GameCategory.AllCategories.ElementAt(1) },
                    new Game { gameName = "Mario", shortDescription = "", longDescription = "", image = "", price = 20, avaliable = true, isFavorite = true, Category = _GameCategory.AllCategories.ElementAt(2) },
                    new Game { gameName = "Call of Duty Modern Warfare II",
                    shortDescription = "", longDescription = "", image = "", price = 79,
                    avaliable = true, isFavorite = false, Category = _GameCategory.AllCategories.ElementAt(1)},
                    new Game { gameName = "Witcher 3",
                    shortDescription = "", longDescription = "", image = "", price = 45,
                    avaliable = true, isFavorite = false, Category = _GameCategory.AllCategories.ElementAt(0)}
                };
            }
            set { }
        }

        public IEnumerable<Game> getFavoriteGames { get; set; }

        public Game GetGame(int gameID)
        {
            throw new NotImplementedException();
        }
    }
}
