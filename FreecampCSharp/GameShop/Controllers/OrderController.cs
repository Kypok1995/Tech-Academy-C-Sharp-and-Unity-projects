using GameShop.Interfaces;
using GameShop.Migrations;
using GameShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly Models.ShopCart shopCart;
        private readonly IAllOrders allOrders;

        public OrderController(Models.ShopCart shopCart, IAllOrders allOrders)
        {
            this.shopCart = shopCart;
            this.allOrders = allOrders;
        }
        



        public IActionResult Checkout()
        {

            return View();
        }
    }
}
