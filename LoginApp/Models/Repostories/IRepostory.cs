﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Models.Repostories
{
    public interface IRepostory<TEntity>
    {
        IList<TEntity> List();

        TEntity Find(int id);

        void Add(TEntity entity);

     

        void Delete(int id);
    }
}
