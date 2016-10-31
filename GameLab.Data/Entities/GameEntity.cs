using System;
using System.Collections.Generic;

namespace GameLab.Data.Entities
{
    public class GameEntity : BaseEntity
    {                                
        public string Title { get; set; }
        
        public string Description { get; set; }

        public string FullDescription { get; set; }
                
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<GameCategoryEntity> GameCategories { get; set; }
    }
}
