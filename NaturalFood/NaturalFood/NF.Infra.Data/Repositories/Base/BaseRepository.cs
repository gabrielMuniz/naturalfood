﻿using NF.Domain.Interfaces.Repositories;
using NF.Infra.Data.Contexts;
using System;
using System.Collections.Generic;

namespace NF.Infra.Data.Repositories.Base
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : class
    {

        protected readonly DefaultContext context;

        public BaseRepository(DefaultContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll() => context.Set<T>();

        public T GetById(int id) => context.Set<T>().Find(id);

        public IEnumerable<T> GetByPredicate(Predicate<T> predicate)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            return context.Set<T>().Update(entity).Entity;
        }
    }
}
