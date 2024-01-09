using GameShop.Interfaces;
using GameShop.Models;
using GameShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IAllGames _gameRep;

    /*    public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public HomeController(IAllGames gameRep)
        {
            _gameRep = gameRep;
        }

        public IActionResult Index()
        {
            var homeGames = new HomeViewModel
            {
                favGames = _gameRep.getFavoriteGames
            };
            return View(homeGames);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}