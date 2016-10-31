using System.Collections.Generic;

using GameLab.Data.Entities;

namespace GameLab.Data.Interfaces
{
    public interface IGameRepository
    {
        GameEntity GetByTitle(string gameTitle);

        List<GameEntity> GetList(int categoryId);        
    }
}
