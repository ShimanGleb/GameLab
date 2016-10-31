using System.Collections.Generic;
using System.Linq;

using GameLab.Data.Entities;
using GameLab.Data.Interfaces;

namespace GameLab.Data.Repository
{
    public class GameRepository : BaseRepository<GameEntity>, IGameRepository
    {        
        public GameRepository(DatabaseContext context) : base(context)
        {
            
        }


        public GameEntity GetByTitle(string gameTitle)
        {
            return Entities.Where(game => game.Title == gameTitle)
                                .Select(game => game)
                                .First();
        }


        public List<GameEntity> GetList(int categoryId)
        {
            List<GameEntity> games = Entities.Where(game => game.GameCategories
                                                  .Where(category => category.CategoryId == categoryId)
                                                     .Select(category => category.Category)
                                                     .FirstOrDefault().Id == categoryId)
                                                  .Select(game => game).ToList<GameEntity>();
            return games;
        }      
    }
}
