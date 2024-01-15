using GameShop.Interfaces;
using GameShop.Migrations;
using GameShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using StackExchange.Redis;

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
        public IActionResult Checkout(Models.Order order)
        {
            shopCart.list_Items = shopCart.GetShopCartItems();
            ModelState.Remove("orderDetails");


            if (shopCart.list_Items.Count == 0)
            {
                ModelState.AddModelError("", "No items in the shop cart");
            }

            if (ModelState.IsValid)
            {
                int orderId = allOrders.createOrder(order);
                //allOrders.createOrder(order);
                return RedirectToAction("Complete", new { orderId });
            }

            if (!ModelState.IsValid)
            {
                // Log or debug ModelState errors
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }

                // Return the view with errors
                return View(order);
            }

            return View(order);
        }

        public IActionResult Complete(int orderId)
        {
            ViewBag.Message = "Order is succesfully placed";

            // Retrieve the order based on orderId
            var order = allOrders.GetOrderById(orderId);

            if (order == null)
            {
                // Handle case where order is not found
                return RedirectToAction("Index"); // Redirect to home or another page
            }

            // Pass the order to the "Complete" view
            return View(order);
            //return View();
        }
    }
}
