using Autofac;
using Microsoft.Owin.Builder;
using Owin;

using GameLab.Data;
using GameLab.Data.UnitOfWork;
using GameLab.Business.Services;
using GameLab.Business.Interfaces;

namespace GameLab.Dependency
{
    public class DependencyConfig : Module
    {
        IAppBuilder app=new AppBuilder();

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType<DatabaseContext>();

            builder.RegisterType<GamesUnitOfWork>();

            builder.RegisterType<CategoryService>().As<ICategoryService>();

            builder.RegisterType<GameService>().As<IGameService>();      

            app.UseAutofacMvc();
        }
    }
}