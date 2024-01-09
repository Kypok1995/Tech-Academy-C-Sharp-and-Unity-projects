namespace GameShop.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int gameID { get; set; }
        public uint price { get; set; }
        public virtual Games game { get; set; }
        public virtual Order order { get; set; }

    }
}
