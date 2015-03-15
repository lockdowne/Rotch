﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oEditor.Repositories
{
    public interface IRepository<T>
    {
        void CheckPath();

        IEnumerable<T> FindEntities(Func<T, bool> predicate);

        void SaveEntity(T entity);

        void RemoveEntities(Func<T, bool> predicate);
        void RemoveEntity(T entity);
    }
}
