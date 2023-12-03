using GameShop.Interfaces;

namespace GameShop.Models.Mocks
{
    public class MockCategory:IGamesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>()//return list of all categories
                {
                    new Category {categoryName = "RPG", categoryDescription = "A role-playing game is a game in which players assume the roles of characters in a fictional setting"},
                    new Category {categoryName = "Shooter", categoryDescription = "Subgenre of action video games where the focus is almost entirely on the defeat of the character's enemies using the weapons given to the player."},
                    new Category {categoryName = "Platformer", categoryDescription = "A platformer requires the player to maneuver their character across platforms to reach a goal while confronting enemies and avoiding obstacles along the way."},
                    new Category {categoryName = "Racing", categoryDescription = "Racing games are a video game genre in which the player participates in a racing competition."}
                };
            }
        }
    }
}
