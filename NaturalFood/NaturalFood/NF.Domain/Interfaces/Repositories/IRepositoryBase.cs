using System;
using System.Collections.Generic;

namespace NF.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {

        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetByPredicate(Predicate<T> predicate);
        int Delete(T entity);
        int Update(T entity);
        IEnumerable<T> GetAll();

    }
}
