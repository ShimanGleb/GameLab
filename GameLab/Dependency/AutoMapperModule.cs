using Autofac;
using AutoMapper;
using System.Collections.Generic;

namespace GameLab.Dependency
{
    public class AutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(Map.ModelMapper).Assembly);

            builder.RegisterAssemblyTypes().AssignableTo(typeof(Profile));

            builder.Register(c => new MapperConfiguration(cfg =>
            {                
                foreach (var profile in c.Resolve<IEnumerable<Profile>>())
                {
                    cfg.AddProfile(profile);
                }
            }));
            
            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>();
        }
    }
}