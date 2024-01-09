using GameShop.Interfaces;
using GameShop.Models;
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
        [Route("Games/List")]
        [Route("Games/List/{category}")]
        public ViewResult List(string category) //method to return viewed result
        {
            string _category = category;
            IEnumerable<Games> games = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))///show all games in the default case
            {
                games = _allGames.games.OrderBy(i => i.gameID);
            }
            else //choose exact category
            {
                if(string.Equals("RPG", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.games.Where(i => i.Category.categoryName.Equals("RPG")).OrderBy(i => i.gameID);
                }

                else if (string.Equals("Shooter", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.games.Where(i => i.Category.categoryName.Equals("Shooter")).OrderBy(i => i.gameID);
                }


                else if (string.Equals("Platformer", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.games.Where(i => i.Category.categoryName.Equals("Platformer")).OrderBy(i => i.gameID);
                }

                else if (string.Equals("Racing", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.games.Where(i => i.Category.categoryName.Equals("Racing")).OrderBy(i => i.gameID);
                }

                currCategory = _category;

          
            }
            
            var gameObj = new GamesListViewModel
            {
                getAllGames = games,
                currentCategory = currCategory
            };

            ViewBag.Title = "All games";
        
            return View(gameObj);
        }
    }
}
