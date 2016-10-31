using AutoMapper;

namespace GameLab.Map
{
    public class CategoryProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Business.Models.Category, Models.Category>();
        }
    }
}