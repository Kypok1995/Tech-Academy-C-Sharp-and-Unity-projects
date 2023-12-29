using GameShop.Models;
using System.Reflection.Metadata;
using System;

namespace GameShop.DB
{
    public class DbObjects
    {
        public  static void Initial(IApplicationBuilder app)
        {
            
            using (var scope = app.ApplicationServices.CreateScope())//to handle database into root scope
            {
               var scopedServices = scope.ServiceProvider;

                try
                {
                    //AppDBContent content = app.ApplicationServices.GetRequiredService<AppDBContent>();// to connect content from database into program.cs

                    AppDBContent content = scopedServices.GetRequiredService<AppDBContent>();//for local scope calling

                    if (!content.Category.Any())//if there are no category content
                    {
                        content.Category.AddRange(Categories.Select(c => c.Value));
                    }

                    if (!content.Games.Any())//if there are no games content
                    {
                        content.AddRange(content.Games);//add games into list
                    }
                    content.SaveChanges();
                }
                catch (Exception ex)
                {
                    // Handle exceptions as needed
                Console.WriteLine("An error occurred during database initialization.");
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)//check if category is null
                {
                    var list = new Category[]//create a new list of categories
                    {
                    new Category {categoryName = "RPG", categoryDescription = "A role-playing game is a game in which players assume the roles of characters in a fictional setting"},
                    new Category {categoryName = "Shooter", categoryDescription = "Subgenre of action video games where the focus is almost entirely on the defeat of the character's enemies using the weapons given to the player."},
                    new Category {categoryName = "Platformer", categoryDescription = "A platformer requires the player to maneuver their character across platforms to reach a goal while confronting enemies and avoiding obstacles along the way."},
                    new Category {categoryName = "Racing", categoryDescription = "Racing games are a video game genre in which the player participates in a racing competition."}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(var c in list)//iterate and add categories into var list
                    {
                        category.Add(c.categoryName, c);
                    }
                }

                return category;
            }
        }
    }
}
