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
    public class EfStudentRepository : IStudentDal
    {
        public Students Create(Students entity)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.Students.Add(entity);
                _dbContext.SaveChanges();
                return entity;
            }
        }

        public bool Delete(int id)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.Students.Remove(Get(id));
                return _dbContext.SaveChanges() > 0;
            }
        }

        public Students Get(int id)
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.Students.AsNoTracking().Where(l => l.Id == id).FirstOrDefault();
            }
        }

        public List<Students> List()
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.Students.AsNoTracking().ToList();
            }
        }

        public List<Students> List(Expression<Func<Students, bool>> predicate)
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.Students.AsNoTracking().Where(predicate).ToList();
            }
        }

        public bool Update(Students entity)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.Students.AddOrUpdate(entity);
                return _dbContext.SaveChanges() > 0;
            }
        }
    }
}
