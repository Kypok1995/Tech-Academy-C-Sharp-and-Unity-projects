using GameShop.Models;

namespace GameShop.Interfaces
{
    public interface IGamesCategory
    {
        IEnumerable<Category> AllCategories { get; }//to return all categories
    }
}
