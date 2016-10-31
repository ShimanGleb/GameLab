using System;
using System.Collections.Generic;
using System.Linq;

using GameLab.Data.Entities;

namespace GameLab.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseContext context = new DatabaseContext();
            
            CategoryEntity category1 = context.Categories.ToList()[0];

            CategoryEntity category2 = context.Categories.ToList()[1];

            CategoryEntity category3 = context.Categories.ToList()[2];

            foreach (CategoryEntity category in context.Categories)
            {
                Console.WriteLine("Id:" + category.Id + " Name: " + category.Name);
            }

            Console.WriteLine("---------------");
            
            /*GameEntity gameEntity = new GameEntity { Title = "Civilization 3", Description = "Become a peacful country to find out why they die out.", FullDescription = "Become an immortal politician who can live longer than ten thousand years. Establish diplomacy with other countries to never understand how in-game political logic works. Develop new technologies to fight countries which didn`t develop new technologies yet. Become a peacful saint or menacing tyrant - the result is only one: tyrant wins.", Year = 2005 };
            gameEntity.GameCategories = new List<GameCategoryEntity>();
            gameEntity.GameCategories.Add(new GameCategoryEntity { Game=gameEntity, Category=category3});
 
            context.Games.Add(gameEntity);
            context.SaveChanges();*/

            for (int i = 0; i < context.Games.ToList().Count; i++)
            {
                Console.WriteLine("Id:" + context.Games.ToList()[i].Id);

                Console.WriteLine("Title:" + context.Games.ToList()[i].Title);

                Console.Write("Categories: ");

                List<GameCategoryEntity> cats = context.Games.ToList()[i].GameCategories.ToList();

                foreach (GameCategoryEntity gameCategory in cats)
                {                    
                    Console.Write(gameCategory.Category.Name + " ");
                }

                Console.WriteLine();

                Console.WriteLine("Description:" + context.Games.ToList()[i].Description);

                Console.WriteLine("Full description:" + context.Games.ToList()[i].FullDescription);

                Console.WriteLine("Year:" + context.Games.ToList()[i].ReleaseDate.Year);

                Console.WriteLine("---------------");
            }

            Console.ReadLine();
        }
    }
}
