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
    }
}
