using System.Collections.Generic;

using GameLab.Business.Models;

namespace GameLab.Business.Interfaces
{
    public interface IGameService
    {
        List<Game> Get(int categoryId);

        Game GetByTitle(string gameTitle);
    }
}
