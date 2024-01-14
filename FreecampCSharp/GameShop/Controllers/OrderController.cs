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

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.list_Items = shopCart.GetShopCartItems();

            if(shopCart.list_Items.Count == 0)
            {
                ModelState.AddModelError("", "No items in the shop cart");
            }

            if(ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order is succesfully placed";
            return View();
        }
    }
}
