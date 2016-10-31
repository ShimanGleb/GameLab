using System.Collections.Generic;

using GameLab.Data.Entities;

namespace GameLab.Data.Interfaces
{
    public interface ICategoryRepository
    {
        List<CategoryEntity> GetList();
    }
}
