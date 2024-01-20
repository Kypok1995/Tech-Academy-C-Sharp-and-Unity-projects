using GameShop.Interfaces;
using GameShop.Models;

namespace GameShop.DB
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent _content;
        private readonly ShopCart shopCart;
  

        public OrdersRepository(AppDBContent content,  ShopCart shopCart)
        {
            _content = content;
            this.shopCart = shopCart; 
           
        }

        
        public int createOrder(Order order)//takes order as parameter and return created order id
        {
            order.orderTime = DateTime.Now;
            

            var items = shopCart.list_Items; //retrieve list of current shop cart items
            //var orderDetails = new List<OrderDetail>();

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    gameID = item.games.gameID,
                    OrderId = order.id,
                    price = item.games.price,
                };

                //orderDetails.Add(orderDetail);
                //_content.OrderDetail.Add(orderDetail); //for future improvements


            }
            _content.Order.Add(order);
            _content.SaveChanges();

            return order.id;
        }

        public Order GetOrderById(int orderId)
        {
            return _content.Order.FirstOrDefault(o => o.id == orderId);
        }
    }
}
