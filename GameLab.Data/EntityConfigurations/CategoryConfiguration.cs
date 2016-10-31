using System.Data.Entity.ModelConfiguration;

using GameLab.Data.Entities;

namespace GameLab.Data.EntityConfigurations
{
    public class CategoryConfiguration : EntityTypeConfiguration<CategoryEntity>
    {
        public CategoryConfiguration()
        {
            ToTable("Category");

            HasKey(k => k.Id);            
        }
    }
}
