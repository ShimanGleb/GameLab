namespace GameLab.Data.Entities
{
    public class GameCategoryEntity : BaseEntity
    {        
        public int GameId { get; set; }

        public int CategoryId { get; set; }

        public virtual CategoryEntity Category { get; set; }

        public virtual GameEntity Game { get; set; }
    }
}