using GameShop.Models;
using System.Reflection.Metadata;
using System;
using GameShop.Interfaces;
using static System.Net.Mime.MediaTypeNames;
using GameShop.Models.Mocks;

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
                        content.AddRange(
                        new Games
                        { gameName = "Oblivion",
                            shortDescription = "Critically acclaimed action role-playing game released in 2006.", 
                            longDescription = "Developed by Bethesda Game Studios, it offers an expansive open-world set in the fantasy realm of Tamriel. Players create a customizable character, engage in a main questline, explore diverse landscapes, and close otherworldly portals called Oblivion Gates. Known for its dynamic Radiant AI system, faction-based quests, and impressive graphics, \"Oblivion\" is a key installment in \"The Elder Scrolls\" series, setting the stage for the series' continued success.", 
                            image = "/img/Oblivion.jpg",
                            price = 35, avaliable = true, isFavorite = true,
                            Category = Categories["RPG"]
                        },
                    new Games
                    {
                        gameName = "Need for Speed: Most Wanted",
                        shortDescription = " Dynamic racing game developed by Criterion Games",
                        longDescription = "Set in the open-world of Fairhaven City, players engage in illegal street races, climb the Most Wanted list by defeating rivals, and customize their cars. The game features intense police pursuits, multiplayer competitions, and Criterion's Autolog system for asynchronous challenges with friends. With impressive graphics and a thrilling soundtrack, it stands as a standout installment in the \"Need for Speed\" series.",
                        image = "/img/NeedForSpeed.jpg",
                        price = 20,
                        avaliable = true,
                        isFavorite = true,
                        Category = Categories["RPG"]
                    },
                    new Games
                    {
                        gameName = "Fortnite",
                        shortDescription = "Popular online multiplayer battle royale game developed by Epic Games. ",
                        longDescription = "Released in 2017, it combines elements of survival, exploration, and building. Players, either solo or in squads, parachute onto an island where they scavenge for weapons, resources, and eliminate opponents. The game is known for its vibrant graphics, unique building mechanic, and frequent updates introducing new content. \"Fortnite\" has gained widespread popularity, attracting a diverse player base across different platforms, and it remains a cultural phenomenon in the gaming world.",
                        image = "/img/Fortnite.jpg",
                        price = 10,
                        avaliable = true,
                        isFavorite = false,
                        Category = Categories["RPG"]
                    },
                    new Games
                    {
                        gameName = "Mario",
                        shortDescription = "Classic video game released by Nintendo in 1985.",
                        longDescription = "In this iconic platformer, players control Mario, a plumber on a quest to rescue Princess Peach from the villainous Bowser. The game is renowned for its side-scrolling gameplay, creative level design, and introduction of power-ups like the Super Mushroom and Fire Flower. Players navigate through Mushroom Kingdom, overcoming obstacles, defeating enemies, and ultimately confronting Bowser to save the princess. \"Super Mario Bros.\" is celebrated as a groundbreaking title that played a pivotal role in shaping the video game industry.",
                        image = "/img/Mario.jpg",
                        price = 20,
                        avaliable = true,
                        isFavorite = true,
                        Category = Categories["RPG"]
                    },
                    new Games
                    {
                        gameName = "Call of Duty Modern Warfare II",
                        shortDescription = " First-person shooter video game developed by Infinity Ward and published by Activision.",
                        longDescription = "Released in 2009, it is part of the acclaimed \"Call of Duty\" series. The game continues the gripping narrative of the original \"Modern Warfare\" and features intense, cinematic gameplay. Players engage in a global conflict, taking on various roles in special forces missions. \"Modern Warfare 2\" is praised for its compelling story, memorable characters, and intense multiplayer mode, making it a landmark title in the first-person shooter genre.",
                        image = "/img/CoD_ModernWarfare_II.jpg",
                        price = 79,
                        avaliable = true,
                        isFavorite = false,
                        Category = Categories["RPG"]
                    },
                    new Games
                    {
                        gameName = "Witcher 3",
                        shortDescription = "Action role-playing game developed by CD Projekt. ",
                        longDescription = "Released in 2015, it follows the adventures of Geralt of Rivia, a monster hunter known as a Witcher. Set in a vast open world, players embark on a quest to find Geralt's adopted daughter, Ciri, and unravel a complex narrative filled with moral choices and consequences. The game is celebrated for its rich storytelling, detailed world, complex characters, and engaging combat. With its expansive landscapes and captivating lore, \"The Witcher 3\" is widely regarded as one of the greatest role-playing games of its time.",
                        image = "/img/Witcher3.jfif",
                        price = 45,
                        avaliable = true,
                        isFavorite = false,
                        Category = Categories["Shooter"]
                    },
                    new Games
                    {
                        gameName = "Starfield",
                        shortDescription = "Starfield is a 2023 action role-playing game developed by Bethesda Game Studios ",
                        longDescription = "In the year 2330, humanity has ventured beyond our solar system, settling new planets, and living as a spacefaring people. You will join Constellation – the last group of space explorers seeking rare artifacts throughout the galaxy – and navigate the vast expanse of space in Bethesda Game Studios’ biggest and most ambitious game.",
                        image = "/img/Starfield.jpg",
                        price = 70,
                        avaliable = true,
                        isFavorite = true,
                        Category = Categories["RPG"]
                    });

                }; //add games into list
                    
                    content.SaveChanges();// to save changes in the database
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
