using AutoMapper;

using GameLab.Data.Entities;
using GameLab.Business.Models;

namespace GameLab.Business.Map
{
    public class CategoryProfile : Profile
    {        
        protected override void Configure()
        {
            CreateMap<CategoryEntity, Category>();
        }
    }
}