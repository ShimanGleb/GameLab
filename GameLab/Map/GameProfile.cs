using AutoMapper;

namespace GameLab.Map
{
    public class GameProfile : Profile
    {
        protected override void Configure()
        {            
            CreateMap<Business.Models.Game, Models.Game>().ForMember(dst=>dst.Release,opt=>opt.MapFrom(src=>src.ReleaseDate));
        }
    }
}