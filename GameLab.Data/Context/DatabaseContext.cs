using System.Data.Entity;

using GameLab.Data.Entities;
using GameLab.Data.EntityConfigurations;

namespace GameLab.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("GameLab")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());

            modelBuilder.Configurations.Add(new GameConfiguration());

            modelBuilder.Configurations.Add(new GameCategoryConfiguration());

            Database.SetInitializer<DatabaseContext>(null);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<GameEntity> Games { get; set; }

        public DbSet<GameCategoryEntity> GameCategory { get; set; }
    }
}
