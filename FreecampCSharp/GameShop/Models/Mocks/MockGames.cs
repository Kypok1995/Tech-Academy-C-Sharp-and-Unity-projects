using GameShop.Interfaces;

namespace GameShop.Models.Mocks
{
    public class MockGames: IAllGames
    {
        private readonly IGamesCategory _GameCategory = new MockCategory();
        public IEnumerable<Games> games
        {
            get
            {
                return new List<Games>
                {
                    new Games { gameName = "Oblivion",
                        shortDescription = "", longDescription = "", image = "",
                        price = 35, avaliable = true, isFavorite = true,
                        Category = _GameCategory.AllCategories.First() },
                    new Games { gameName = "Need for Speed: Most Wanted",
                        shortDescription = "", longDescription = "", image = "",
                        price = 20, avaliable = true, isFavorite = true,
                        Category = _GameCategory.AllCategories.ElementAt(3) },
                    new Games { gameName = "Fortnite",
                        shortDescription = "", longDescription = "", image = "",
                        price = 10, avaliable = true, isFavorite = false,
                        Category = _GameCategory.AllCategories.ElementAt(1) },
                    new Games { gameName = "Mario",
                        shortDescription = "", longDescription = "", image = "",
                        price = 20, avaliable = true, isFavorite = true,
                        Category = _GameCategory.AllCategories.ElementAt(2) },
                    new Games { gameName = "Call of Duty Modern Warfare II",
                        shortDescription = "", longDescription = "", image = "", price = 79,
                    avaliable = true, isFavorite = false,
                        Category = _GameCategory.AllCategories.ElementAt(1)},
                    new Games { gameName = "Witcher 3",
                        shortDescription = "", longDescription = "", image = "", price = 45,
                    avaliable = true, isFavorite = false,
                        Category = _GameCategory.AllCategories.ElementAt(0)}

                };
            }
            set { }
        }

        public IEnumerable<Games> getFavoriteGames { get; set; }

        public Games GetGame(int gameID)
        {
            throw new NotImplementedException();
        }
    }
}

