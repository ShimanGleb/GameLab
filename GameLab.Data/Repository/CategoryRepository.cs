using GameLab.Data.Entities;
using GameLab.Data.Interfaces;

namespace GameLab.Data.Repository
{
    public class CategoryRepository : BaseRepository<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository(DatabaseContext context) : base(context)
        {
            
        }
    }
}