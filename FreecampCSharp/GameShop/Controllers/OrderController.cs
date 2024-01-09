using GameShop.Interfaces;
using GameShop.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ShopCart shopCart;
        private readonly IAllOrders allOrders;

        public OrderController(ShopCart shopCart, IAllOrders allOrders)
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
