using System.Collections.Generic;

using GameLab.Data.UnitOfWork;

using GameLab.Business.Interfaces;
using GameLab.Business.Map;
using GameLab.Business.Models;

namespace GameLab.Business.Services
{
    public class GameService : IGameService
    {
        private GamesUnitOfWork _unitOfWork;

        private ModelMapper ModelMapper;

        public GameService(GamesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            ModelMapper = new ModelMapper();
        }

        public List<Game> Get(int categoryId)
        {
            List<Game> games = ModelMapper.Mapper.Map<List<Game>>(_unitOfWork.Games.GetList(categoryId));

            return games;
        }

        public Game GetByTitle(string gameTitle)
        {
            Game game = ModelMapper.Mapper.Map<Game>(_unitOfWork.Games.GetByTitle(gameTitle));

            return game;
        }
    }
}
