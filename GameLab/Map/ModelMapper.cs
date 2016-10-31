using AutoMapper;

namespace GameLab.Map
{
    public class ModelMapper
    {
        public IMapper Mapper;

        public ModelMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.AddProfile<CategoryProfile>();
                cfg.AddProfile<GameProfile>();
            });

            Mapper = config.CreateMapper();
        }
    }
}