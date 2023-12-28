namespace GameShop.Models
{
    public class Games
    {
        //variable needed for game class
  
        public int gameID {get; set; }
        public string gameName { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public string image { get; set; }
        public ushort price { get; set; }//price cannot be negative
        public bool isFavorite { get; set; }
        public bool avaliable { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
