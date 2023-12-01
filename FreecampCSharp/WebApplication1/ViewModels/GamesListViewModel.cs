using WebApplication1.Data.Models;

namespace WebApplication1.ViewModels
{
    public class GamesListViewModel
    {
        public IEnumerable<Games> getAllGames {  get; set; }
        public string currentCategory { get; set; }
    }
}
