using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Scheduler.DataAccess.Interfaces;
using Scheduler.Core.Models;

namespace Scheduler.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SchedulerDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(SchedulerDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
