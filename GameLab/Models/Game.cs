using System;
using System.Collections.Generic;

namespace GameLab.Models
{
    public class Game
    {
        public List<int> CategoryIds { get; set; }

        public int Id { get; set; }

        public string Description { get; set; }

        public int GetCategoryAmount()
        {
            return CategoryIds.Count;
        }


        public int GetCategoryId(int index)
        {
            return CategoryIds[index];
        }

        public string FullDescription { get; set; }

        public string Title { get; set; }

        public DateTime Release { get; set; }

    }
}