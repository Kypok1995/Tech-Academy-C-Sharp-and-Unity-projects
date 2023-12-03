using GameShop.Interfaces;
using GameShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Controllers
{
    public class GamesController : Controller
    {
        private readonly IAllGames _allGames;
        private readonly IGamesCategory _allCategories;

        public GamesController(IAllGames iallGames, IGamesCategory iallCategories) //main constructor 
        {
            _allGames = iallGames;
            _allCategories = iallCategories;
        }

        public ViewResult List() //method to return viewed result
        {
            ViewBag.Title = "All games";
            GamesListViewModel obj = new GamesListViewModel();
            obj.getAllGames = _allGames.games;
            obj.currentCategory = "Games";
            return View(obj);
        }
    }
}
