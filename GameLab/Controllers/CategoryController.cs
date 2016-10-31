using System.Collections.Generic;
using System.Web.Mvc;

using GameLab.Business.Interfaces;
using GameLab.Models;

namespace GameLab.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        private IGameService _gameService;

        private Map.ModelMapper _mapper;

        public static DataKeeper keeper;

        public CategoryController(ICategoryService categoryService, IGameService gameService, Map.ModelMapper mapper)
        {
            _categoryService = categoryService;

            _gameService = gameService;

            _mapper = mapper;     
        }
        
        public ActionResult GetCategories()
        {
            keeper = new DataKeeper();
            
            return View(_mapper.Mapper.Map<List<Category>>(_categoryService.Get()));
        }

        public ActionResult GetGames(string categoryName)
        {
            
            keeper.Categories = _mapper.Mapper.Map<List<Category>>(_categoryService.Get());

            ViewData["Categories"] = keeper.Categories;

            ViewData["CurrentCategoryId"] = keeper.GetCategoryIdByName(categoryName);

            keeper.Games = _mapper.Mapper.Map<List<Game>>(_gameService.Get(
                                                        keeper.GetCategoryIdByName(categoryName)));

            ViewData["Games"] = keeper.Games;

            return View(keeper.Games);
        }

        public ActionResult GetFullGameDescription(string gameTitle)
        {
            Game game = _mapper.Mapper.Map < Game > (_gameService.GetByTitle(gameTitle));                      

            ViewData["Categories"] = keeper.GetCategoryNamesByIds(game.CategoryIds);

            return View(game);
        }
    }
}