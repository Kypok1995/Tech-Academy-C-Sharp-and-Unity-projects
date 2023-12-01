using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Interfaces;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers;

public class Games : Controller
{
    private readonly IAllGames _allGames;
    private readonly IGamesCategory _allCategories;

    public Games(IAllGames iallGames, IGamesCategory iallCategories) //main constructor 
    {
        _allGames = iallGames;
        _allCategories = iallCategories;
    }

    public IActionResult List()
    {
        ViewBag.Title = "All games";
        GamesListViewModel obj = new GamesListViewModel();
        obj.getAllGames = _allGames.games;
        obj.currentCategory = "Games";
        return View(obj);
    }
}
