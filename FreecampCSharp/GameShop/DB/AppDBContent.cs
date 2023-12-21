using GameShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GameShop.DB
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Games> Games { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
