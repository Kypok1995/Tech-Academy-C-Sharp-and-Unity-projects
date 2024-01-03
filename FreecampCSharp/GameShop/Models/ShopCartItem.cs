namespace GameShop.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Games games { get; set; }
        public int price { get; set; }
        public string ShopCartID { get; set; }


    }
}
