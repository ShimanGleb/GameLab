using System.Data.Entity.ModelConfiguration;

using GameLab.Data.Entities;

namespace GameLab.Data.EntityConfigurations
{
    class GameCategoryConfiguration : EntityTypeConfiguration<GameCategoryEntity>
    {
        public GameCategoryConfiguration()
        {
            ToTable("GameCategory");

            HasRequired(c => c.Category)
            .WithMany(t => t.GameCategories)
            .HasForeignKey(x => x.CategoryId);

            HasRequired(c => c.Game)
            .WithMany(t => t.GameCategories)
            .HasForeignKey(x => x.GameId);
        }
    }
}
