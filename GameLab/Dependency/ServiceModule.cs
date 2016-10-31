using Autofac;
using System.Linq;

using GameLab.Business.Services;

namespace GameLab.Dependency
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(typeof(CategoryService).Assembly)
                      .Where(t => t.Name.EndsWith("Service"))
                      .AsImplementedInterfaces()
                      .InstancePerRequest();
        }
    }
}