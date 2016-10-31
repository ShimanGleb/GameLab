using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using GameLab.Data.Entities;

namespace GameLab.Data.Repository
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private DatabaseContext Context;

        protected IDbSet<T> Entities;

        public BaseRepository(DatabaseContext context)
        {
            Context = context;

            Entities = context.Set<T>();
        }

        public List<T> GetList()
        {
            return Entities.Select(t=>t).ToList();
        }
    }
}