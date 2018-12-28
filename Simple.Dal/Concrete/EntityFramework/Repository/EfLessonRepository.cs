using Simple.Dal.Abstract;
using Simple.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Dal.Concrete.EntityFramework.Repository
{
    public class EfLessonRepository : ILessonDal
    {
        public Lessons Create(Lessons entity)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.Lessons.Add(entity);
                _dbContext.SaveChanges();
                return entity;
            }
        }

        public bool Delete(int id)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.Lessons.Remove(Get(id));
                return _dbContext.SaveChanges() > 0;
            }
        }

        public Lessons Get(int id)
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.Lessons.AsNoTracking().Where(l => l.Id == id).FirstOrDefault();
            }
        }

        public List<Lessons> List()
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.Lessons.AsNoTracking().ToList();
            }
        }

        public List<Lessons> List(Expression<Func<Lessons, bool>> predicate)
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.Lessons.AsNoTracking().Where(predicate).ToList();
            }
        }

        public bool Update(Lessons entity)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.Lessons.AddOrUpdate(entity);
                return _dbContext.SaveChanges() > 0;
            }
        }
    }
}
