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
    class EfLessonsInfoRepository : ILessonInfo
    {
        public LessonsInfo Create(LessonsInfo entity)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.LessonsInfo.Add(entity);
                _dbContext.SaveChanges();
                return entity;
            }
        }

        public bool Delete(int lessonId, int teacherId)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.LessonsInfo.Remove(Get(lessonId, teacherId));
                return _dbContext.SaveChanges() > 0;
            }
        }

        public LessonsInfo Get(int lessonId, int teacherId)
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.LessonsInfo.AsNoTracking().Where(l => l.LessonId == lessonId && l.TeacherId == teacherId).FirstOrDefault();
            }
        }

        public List<LessonsInfo> List()
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.LessonsInfo.AsNoTracking().ToList();
            }
        }

        public List<LessonsInfo> List(Expression<Func<LessonsInfo, bool>> predicate)
        {
            using (var _dbContext = new simpleDbContext())
            {
                return _dbContext.LessonsInfo.AsNoTracking().Where(predicate).ToList();
            }
        }

        public bool Update(LessonsInfo entity)
        {
            using (var _dbContext = new simpleDbContext())
            {
                _dbContext.LessonsInfo.AddOrUpdate(entity);
                return _dbContext.SaveChanges() > 0;
            }
        }
    }
}
