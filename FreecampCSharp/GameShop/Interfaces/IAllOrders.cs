using GameShop.Models;

namespace GameShop.Interfaces
{
    public interface IAllOrders
    {
        int createOrder(Order order);

        Order GetOrderById(int orderId);

    }

}
