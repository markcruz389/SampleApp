using Microsoft.EntityFrameworkCore;
using SampleApp.Service.Contracts.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SampleApp.Service.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly SampleAppDbContext _dbContext;

        public BaseRepository(SampleAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbContext.Set<T>().Find(id);

            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IReadOnlyList<T> ListAll()
        {
            return _dbContext.Set<T>().ToList();
        }
    }
}
