using GameShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.ViewModels
{
    public class GamesListViewModel
    {
        public IEnumerable<Games> getAllGames { get; set; }
        public string currentCategory { get; set; }
    }
}
