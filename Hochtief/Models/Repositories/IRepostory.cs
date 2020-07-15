using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models.Repositories
{
    public interface IRepostory<TEntity>
    {
        IList<TEntity> List();

        TEntity Find(int id);

        void Add(TEntity entity);

        void Update(int id , TEntity entity);

        void Delete(int id); 
    }
}
