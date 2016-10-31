using AutoMapper;

using GameLab.Data.Entities;
using GameLab.Business.Models;

namespace GameLab.Business.Map
{
    public class GameProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<GameCategoryEntity, int>().ConvertUsing(source =>
                                                                (source.SourceValue as GameCategoryEntity).CategoryId);

            CreateMap<GameEntity, Game>().ForMember(dest => dest.CategoryIds, opt => opt.MapFrom(src => src.GameCategories));
        }        
    }
}
