using System.Collections.Generic;

using GameLab.Data.UnitOfWork;

using GameLab.Business.Interfaces;
using GameLab.Business.Map;
using GameLab.Business.Models;


namespace GameLab.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private GamesUnitOfWork _unitOfWork;

        private ModelMapper ModelMapper;

        public CategoryService(GamesUnitOfWork unitOfWork)
        {           
            _unitOfWork = unitOfWork;

            ModelMapper = new ModelMapper();
        }

        public List<Category> Get()
        {
            List<Category> categories = ModelMapper.Mapper.Map<List<Category>>(_unitOfWork.Categories.GetList());

            return categories;
        }        
    }
}