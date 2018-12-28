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
    class EfTeacherRepository : ITeacherDal
    {
        public Teachers Create(Teachers entity)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.Teachers.Add(entity);
                _dbContext.SaveChanges();
                return entity;
            }
        }

        public bool Delete(int id)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.Teachers.Remove(Get(id));
                return _dbContext.SaveChanges() > 0;
            }
        }

        public Teachers Get(int id)
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.Teachers.AsNoTracking().Where(l => l.Id == id).FirstOrDefault();
            }
        }

        public List<Teachers> List()
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.Teachers.AsNoTracking().ToList();
            }
        }

        public List<Teachers> List(Expression<Func<Teachers, bool>> predicate)
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.Teachers.AsNoTracking().Where(predicate).ToList();
            }
        }

        public bool Update(Teachers entity)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.Teachers.AddOrUpdate(entity);
                return _dbContext.SaveChanges() > 0;
            }
        }
    }
}
