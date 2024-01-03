using GameShop.DB;
using GameShop.Interfaces;
using GameShop.Migrations;
using GameShop.Models;
using GameShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;

namespace GameShop.Controllers
{
    public class ShopCartController: Controller
    {
        private readonly IAllGames _gameRepository;
        private readonly Models.ShopCart _shopCart;

        public ShopCartController(IAllGames gameRepository, Models.ShopCart shopCart)
        {
            _gameRepository = gameRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var Items = _shopCart.GetShopCartItems();
            _shopCart.list_Items = Items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart,
            };

            return View(obj);//returnes a view with obj consisting current shop cart
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _gameRepository.games.FirstOrDefault(i => i.gameID == id);//search for an item based on id
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");//redirect iser to car page
        }
    }
}
