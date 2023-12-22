using GameShop.Interfaces;
using GameShop.Models;

namespace GameShop.DB
{
    public class CategoryRepository : IGamesCategory
    {

        private readonly AppDBContent appDBContent;
        public CategoryRepository (AppDBContent appDBContent, IEnumerable<Games> games, IEnumerable<Games> getFavoriteGames)
        {
            this.appDBContent = appDBContent;

        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;//return all categories

    }
}
