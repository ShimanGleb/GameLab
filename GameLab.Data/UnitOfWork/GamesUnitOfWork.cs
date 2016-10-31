using GameLab.Data.Interfaces;
using GameLab.Data.Repository;

namespace GameLab.Data.UnitOfWork
{
    public class GamesUnitOfWork : IGamesUnitOfWork
    {
        private DatabaseContext _context;

        private ICategoryRepository _categoryRepository;

        private IGameRepository _gameRepository;

        public GamesUnitOfWork(DatabaseContext context)
        {
            _context = context;

            _categoryRepository = new CategoryRepository(context);

            _gameRepository = new GameRepository(context);                        
        }


        public ICategoryRepository Categories
        {            
            get
            {                
                return _categoryRepository;
            }
        }


        public IGameRepository Games
        {
            get
            {
                return _gameRepository;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}