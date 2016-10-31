using System.Collections.Generic;

namespace GameLab.Data.Entities
{
    public class CategoryEntity : BaseEntity
    {                
        public string Name { get; set; }

        public virtual ICollection<GameCategoryEntity> GameCategories { get; set; }
    }
}
