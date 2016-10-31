using System.Collections.Generic;

using GameLab.Business.Models;

namespace GameLab.Business.Interfaces
{
    public interface ICategoryService
    {
        List<Category> Get();
    }
}
