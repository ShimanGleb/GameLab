using System;
using System.Collections.Generic;

namespace GameLab.Business.Models
{
    public class Game
    {        
        public List<int> CategoryIds { get; set; }

        public int Id { get; set; }

        public string Description { get; set; }

        public string FullDescription { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
