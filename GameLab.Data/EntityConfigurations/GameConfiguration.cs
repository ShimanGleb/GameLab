using System.Data.Entity.ModelConfiguration;

using GameLab.Data.Entities;

namespace GameLab.Data.EntityConfigurations
{
    class GameConfiguration : EntityTypeConfiguration<GameEntity>
    {
        public GameConfiguration()
        {
            ToTable("Game");

            HasKey(k => k.Id);

            Property(p => p.Title).IsRequired();

            Property(p => p.ReleaseDate).HasColumnType("date");
        }
    }
}