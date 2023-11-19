namespace WebApplication1.Data.Models
{
    public class Category
    {
        // main variable to describe category 
        public int id { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public List<Game> games { get; set; }
    }
}
