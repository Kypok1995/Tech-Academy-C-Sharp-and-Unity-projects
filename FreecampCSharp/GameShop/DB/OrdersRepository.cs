using GameShop.Interfaces;
using GameShop.Models;

namespace GameShop.DB
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent _content;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent content, ShopCart shopCart)
        {
            _content = content;
            this.shopCart = shopCart;
        }

        
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            _content.Order.Add(order);

            var items = shopCart.list_Items;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    gameID = item.games.gameID,
                    OrderId = order.id,
                    price = item.games.price,
                };

                _content.OrderDetail.Add(orderDetail);
            }

            _content.SaveChanges();
        }
    }
}
