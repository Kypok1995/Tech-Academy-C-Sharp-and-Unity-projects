using GameShop.DB;
using Microsoft.EntityFrameworkCore;

namespace GameShop.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart (AppDBContent appDBContent)//constructor for implementing database
        {
            this.appDBContent = appDBContent;
        }

        public string  ShopCartId { get; set; }

        public List<ShopCartItem> list_Items { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;//creating a new session for the user

            var context = services.GetService<AppDBContent>();
            string shopCartID = session.GetString("CartId") ?? Guid.NewGuid().ToString();//checks if cart ID already existing, if not - assign a new pne

            session.SetString("CartId", shopCartID);//assign an ID to the session

            return new ShopCart(context) { ShopCartId = shopCartID };//returnes a new ShopCart with current ID
        }

        public void AddToCart(Games game)
        {
            this.appDBContent.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartID = ShopCartId,
                games = game,
                price = game.price
            });

            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopCartItems()
        {
            return appDBContent.ShopCartItems.Where(c => c.ShopCartID == ShopCartId).Include(s => s.games).ToList();//return a list of items in shop cart, where ShopCarID is equal
        
        }
    }
}
