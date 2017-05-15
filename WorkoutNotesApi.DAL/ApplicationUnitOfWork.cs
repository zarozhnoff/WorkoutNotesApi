using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutNotesApi.DAL.Interfaces;
using WorkoutNotesApi.DAL.Repositories;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.DAL
{
    public class ApplicationUnitOfWork : IApplicationUnitOfWork
    {
        private IDictionary<Type, Type> _entityTypeToRepositoryType;
        private readonly Dictionary<Type, object> _repositories;

        private readonly IApplicationDbContext _context;


        public ApplicationUnitOfWork(IApplicationDbContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();

            InitializeRepositoryMapping();
        }


        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.Keys.Contains(typeof(TEntity)))
            {
                return _repositories[typeof(TEntity)] as IRepository<TEntity>;
            }

            var repository = CreateRepository<TEntity>();
            _repositories.Add(typeof(TEntity), repository);

            return repository;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
        }


        private IRepository<TEntity> CreateRepository<TEntity>() where TEntity : class
        {
            Type repositoryType;
            var repository = _entityTypeToRepositoryType.TryGetValue(typeof(TEntity), out repositoryType)
                ? (Repository<TEntity>)Activator.CreateInstance(repositoryType, _context)
                : new Repository<TEntity>(_context);

            return repository;
        }

        private void InitializeRepositoryMapping()
        {
            _entityTypeToRepositoryType = new Dictionary<Type, Type>
            {
                { typeof(Muscle), typeof(MusclesRepository) }
            };
        }
    }
}