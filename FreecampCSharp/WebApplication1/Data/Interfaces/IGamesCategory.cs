using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interfaces
{
    public interface IGamesCategory
    {
        IEnumerable<Category> AllCategories { get; }//to return all categories
    }
}
