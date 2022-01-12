using NF.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace NF.Infra.Data.Repositories.Base
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : class
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetByPredicate(Predicate<T> predicate)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
