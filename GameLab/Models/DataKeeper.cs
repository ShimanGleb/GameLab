using System.Collections.Generic;

namespace GameLab.Models
{
    public class DataKeeper
    {        
        public List<Category> Categories { get; set; }

        public List<Game> Games { get; set; }

        public int GetCategoryIdByName(string name)
        {
            foreach (Category category in Categories)
            {
                if (category.Name.ToLower().Equals(name.ToLower())) return category.Id;
            }
            return -1;
        }


        public string GetCategoryNameById(int id)
        {
            foreach (Category category in Categories)
            {
                if (category.Id.Equals(id)) return category.Name;
            }
            return "";
        }


        public List<string> GetCategoryNamesByIds(List<int> categoryIds)
        {
            List<string> categories = new List<string>();            

            foreach (int categoryId in categoryIds)
            {
                categories.Add(GetCategoryNameById(categoryId));
            }

            return categories;
        }


        public int GetGameIdByTitle(string title)
        {
            foreach (Game game in Games)
            {
                if (game.Title.ToLower().Equals(title.ToLower())) return game.Id;
            }
            return -1;
        }
    }    
}