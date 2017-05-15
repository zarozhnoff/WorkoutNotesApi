﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WorkoutNotesApi.DAL.Interfaces;

namespace WorkoutNotesApi.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbset;


        protected readonly IApplicationDbContext Context;


        public Repository(IApplicationDbContext context)
        {
            Context = context;
            _dbset = context.Set<T>();
        }


        public async Task<IReadOnlyCollection<T>> GetAllAsync()
        {
            return await GetAllQuery().ToListAsync();
        }

        protected virtual IQueryable<T> GetAllQuery()
        {
            return _dbset;
        }

        protected IQueryable<T> GetQuery(params Expression<Func<T, object>>[] includes)
        {
            return includes.Aggregate<Expression<Func<T, object>>, IQueryable<T>>(_dbset, (current, include) => current.Include(include));
        }
    }
}