using GameShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GameShop.DB
{
    public class AppDBContent : DbContext//inherits from main database configuration class
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Games> Games { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//to automatically add primary key based on game id
        {
            modelBuilder.Entity<Games>().HasKey(g => g.gameID);
        }
    }
}
